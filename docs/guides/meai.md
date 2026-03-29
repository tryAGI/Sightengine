# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Sightengine SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Sightengine's image and text moderation, AI-generated image detection, and username validation.

## Installation

```bash
dotnet add package Sightengine
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsModerateImageTool()` | `ModerateImage` | Moderate an image URL for nudity, violence, gore, weapons, drugs, and more |
| `AsDetectAiGeneratedTool()` | `DetectAiGeneratedImage` | Detect whether an image was AI-generated |
| `AsModerateTextTool()` | `ModerateText` | Moderate text for profanity, personal information, and links |
| `AsValidateUsernameTool()` | `ValidateUsername` | Validate a username for profanity and misleading content |

## Usage

```csharp
using Sightengine;
using Microsoft.Extensions.AI;

var sightengineClient = new SightengineClient(
    apiKey: Environment.GetEnvironmentVariable("SIGHTENGINE_API_USER")! + ":" +
            Environment.GetEnvironmentVariable("SIGHTENGINE_API_SECRET")!);

var options = new ChatOptions
{
    Tools =
    [
        sightengineClient.AsModerateImageTool(),
        sightengineClient.AsDetectAiGeneratedTool(),
        sightengineClient.AsModerateTextTool(),
        sightengineClient.AsValidateUsernameTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Check if this image is AI-generated: https://example.com/photo.jpg"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
