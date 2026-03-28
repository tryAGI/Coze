#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/coze-dev/coze-sdk-gen/main/coze-openapi.yaml

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
