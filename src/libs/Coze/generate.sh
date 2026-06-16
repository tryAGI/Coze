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

autosdk generate openapi.yaml \
  --namespace Coze \
  --clientClassName CozeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
