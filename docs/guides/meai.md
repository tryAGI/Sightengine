# Microsoft.Extensions.AI Integration

The Sightengine SDK provides `AIFunction` tools that can be used with any `IChatClient` from the Microsoft.Extensions.AI ecosystem.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsModerateImageTool()` | Moderate an image URL for nudity, violence, gore, weapons, drugs, alcohol, offensive content, self-harm, and scam |
| `AsDetectAiGeneratedTool()` | Detect whether an image was AI-generated |
| `AsModerateTextTool()` | Moderate text for profanity, personal information, and links |
| `AsValidateUsernameTool()` | Validate a username for profanity and misleading content |

## Usage

```csharp
using Sightengine;
using Microsoft.Extensions.AI;

// Create Sightengine client
var sightengine = new SightengineClient(
    apiUser: Environment.GetEnvironmentVariable("SIGHTENGINE_API_USER")!,
    apiSecret: Environment.GetEnvironmentVariable("SIGHTENGINE_API_SECRET")!);

// Create tools
var moderateImageTool = sightengine.AsModerateImageTool();
var detectAiTool = sightengine.AsDetectAiGeneratedTool();
var moderateTextTool = sightengine.AsModerateTextTool();

// Use with any IChatClient
IChatClient chatClient = /* your preferred chat client */;
var response = await chatClient.GetResponseAsync(
    "Is this image safe? https://example.com/image.jpg",
    new ChatOptions
    {
        Tools = [moderateImageTool, detectAiTool],
    });
```

## Custom Models

You can customize which detection models to use with `AsModerateImageTool()`:

```csharp
// Only check for nudity and violence
var tool = sightengine.AsModerateImageTool(
    models: "nudity-2.1,violence");

// Full moderation suite
var fullTool = sightengine.AsModerateImageTool(
    models: "nudity-2.1,gore-2.0,weapon,drugs,violence,alcohol,offensive,self-harm,scam");
```
