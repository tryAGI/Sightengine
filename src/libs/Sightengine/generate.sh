#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no public spec available)
install_autosdk_cli

rm -rf Generated

# Sightengine has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: --security-scheme Http:Header:Bearer generates a constructor that accepts an apiKey.
#       A PrepareRequest hook extracts the Bearer token (formatted as "api_user:api_secret"),
#       removes the Authorization header, and adds api_user + api_secret query parameters.
autosdk generate openapi.yaml \
  --namespace Sightengine \
  --clientClassName SightengineClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/Sightengine.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Sightengine.CLI \
  --sdk-project ../../libs/Sightengine/Sightengine.csproj \
  --targetFramework net10.0 \
  --namespace Sightengine \
  --clientClassName SightengineClient \
  --package-id Sightengine.CLI \
  --tool-command-name sightengine \
  --user-secrets-id Sightengine.CLI \
  --api-key-env-var SIGHTENGINE_API_KEY \
  --base-url-env-var SIGHTENGINE_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
