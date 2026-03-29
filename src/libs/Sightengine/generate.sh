#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease

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
