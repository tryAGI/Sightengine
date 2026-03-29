# CLAUDE.md -- Sightengine SDK

## Overview

Auto-generated C# SDK for [Sightengine](https://sightengine.com/) -- visual content moderation platform with 120+ detection classes covering nudity, violence, hate speech, drugs, weapons, self-harm, and more. Supports images, videos, live streams, and text moderation in 200+ languages.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Sightengine API documentation.

## Build & Test

```bash
dotnet build Sightengine.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Sightengine uses dual query parameters (`api_user` + `api_secret`) for authentication. The SDK provides two constructor patterns:

```csharp
// Option 1: Separate parameters (recommended)
var client = new SightengineClient(apiUser: "your_user", apiSecret: "your_secret");

// Option 2: Combined "user:secret" format
var client = new SightengineClient(apiKey: "your_user:your_secret");
```

The `PrepareRequest` hook extracts the Bearer token (formatted as `api_user:api_secret`), removes the `Authorization` header, and adds `api_user` + `api_secret` as query parameters to every request.

## Key Files

- `src/libs/Sightengine/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Sightengine)
- `src/libs/Sightengine/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer` (no download step)
- `src/libs/Sightengine/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Sightengine/Extensions/SightengineClient.Auth.cs` -- PrepareRequest hook: Bearer → query params
- `src/libs/Sightengine/Extensions/SightengineClient.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with dual api_user/api_secret auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Sightengine API docs
- All endpoints are at `https://api.sightengine.com/1.0`
- Auth: `--security-scheme Http:Header:Bearer` generates constructor; `PrepareRequest` hook converts Bearer token to query params

## Auth Hook

Sightengine uses `api_user` + `api_secret` as query parameters (not headers). The `PrepareRequest` hook in `Extensions/SightengineClient.Auth.cs`:

1. Intercepts the Bearer token (formatted as `api_user:api_secret`)
2. Removes the `Authorization` header
3. Appends `api_user` and `api_secret` as query parameters

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/check.json` | GET/POST | Image moderation (URL or upload) with 15+ models |
| `/check-workflow.json` | GET/POST | Workflow-based image moderation |
| `/video/check-sync.json` | POST | Synchronous video moderation (under 60s) |
| `/video/check.json` | POST | Asynchronous video/live stream moderation |
| `/text/check.json` | POST | Text moderation (profanity, PII, links) |
| `/feedback.json` | POST | Submit moderation feedback (free) |

## Detection Models

`nudity-2.1`, `gore-2.0`, `weapon`, `drugs`, `violence`, `alcohol`, `offensive`, `self-harm`, `scam`, `face-attributes`, `text-content`, `qr-content`, `genai`, `type`, `quality`

## MEAI AIFunction Tools

- `AsModerateImageTool()` -- Moderate image URL for harmful content
- `AsDetectAiGeneratedTool()` -- Detect AI-generated images
- `AsModerateTextTool()` -- Moderate text for profanity and PII
- `AsValidateUsernameTool()` -- Validate username for profanity and misleading content
