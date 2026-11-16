#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/coze-dev/coze-sdk-gen/main/coze-openapi.yaml
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/coze-dev/coze-sdk-gen/main/coze-openapi.yaml

# Fix server URL: add international endpoint as primary, keep CN as secondary
python3 -c "
import yaml
with open('openapi.yaml') as f:
    d = yaml.safe_load(f)
d['servers'] = [
    {'url': 'https://api.coze.com', 'description': 'International'},
    {'url': 'https://api.coze.cn', 'description': 'China'}
]
with open('openapi.yaml', 'w') as f:
    yaml.dump(d, f, default_flow_style=False, allow_unicode=True, sort_keys=False, width=200)
"

# The document declares CanvasPosition twice: CanvasPosition and CanvasPosition1, the same four
# number properties. Not an AutoSDK name collision - the names genuinely differ, so nothing merges
# them and the SDK ships both.
#
# This is a merge, not a deletion. The numbered copy is the DOCUMENTED one: its properties carry
# `title` and `x-coze-example`, which become XML docs in the generated code, and the bare
# CanvasPosition has none. So the clean name keeps the richer content and the numbered name goes.
#
# Equality is checked on the shape only - type, properties, required - ignoring documentation and
# vendor extensions, because those are exactly what differs here. A future spec that makes the
# shapes differ fails this step instead of silently merging two different schemas.
python3 -c "
import sys, yaml

SURVIVOR, DUPLICATE = 'CanvasPosition', 'CanvasPosition1'
DOCUMENTATION = ('title', 'description', 'example', 'examples', 'default')

def shape(node):
    if isinstance(node, dict):
        return {k: shape(v) for k, v in sorted(node.items())
                if k not in DOCUMENTATION and not k.startswith('x-')}
    if isinstance(node, list):
        return [shape(v) for v in node]
    return node

with open('openapi.yaml') as f:
    spec = yaml.safe_load(f)

schemas = spec.get('components', {}).get('schemas', {})
if DUPLICATE in schemas:
    if SURVIVOR not in schemas:
        sys.exit(f'{SURVIVOR} is gone; review before merging {DUPLICATE} into it')
    if shape(schemas[SURVIVOR]) != shape(schemas[DUPLICATE]):
        sys.exit(f'{DUPLICATE} no longer has the same shape as {SURVIVOR}; review before merging')
    schemas[SURVIVOR] = schemas.pop(DUPLICATE)

    def repoint(node):
        if isinstance(node, dict):
            ref = node.get('\$ref')
            if ref == f'#/components/schemas/{DUPLICATE}':
                node['\$ref'] = f'#/components/schemas/{SURVIVOR}'
            for value in node.values():
                repoint(value)
        elif isinstance(node, list):
            for value in node:
                repoint(value)

    repoint(spec)
    print(f'Merged {DUPLICATE} into {SURVIVOR}.')

with open('openapi.yaml', 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, allow_unicode=True, sort_keys=False, width=200)
"

autosdk generate openapi.yaml \
  --namespace Coze \
  --clientClassName CozeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
