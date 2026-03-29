#nullable enable

using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Sightengine;

/// <summary>
/// Extensions for using SightengineClient as MEAI AIFunction tools with any IChatClient.
/// </summary>
public static class SightengineToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that moderates an image URL for harmful content
    /// (nudity, violence, gore, weapons, drugs, alcohol, offensive, self-harm, scam).
    /// </summary>
    /// <param name="client">The Sightengine client to use.</param>
    /// <param name="models">Comma-separated detection models (default: "nudity-2.1,gore-2.0,weapon,drugs,violence,alcohol,offensive,self-harm,scam").</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsModerateImageTool(
        this SightengineClient client,
        string models = "nudity-2.1,gore-2.0,weapon,drugs,violence,alcohol,offensive,self-harm,scam")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string imageUrl, CancellationToken cancellationToken) =>
            {
                var response = await client.CheckImageByUrlAsync(
                    url: imageUrl,
                    models: models,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatImageCheckResponse(response);
            },
            name: "ModerateImage",
            description: "Moderate an image URL for harmful content including nudity, violence, gore, weapons, drugs, alcohol, offensive content, self-harm, and scam. Returns confidence scores (0-1) for each category.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that detects AI-generated images.
    /// </summary>
    /// <param name="client">The Sightengine client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsDetectAiGeneratedTool(
        this SightengineClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string imageUrl, CancellationToken cancellationToken) =>
            {
                var response = await client.CheckImageByUrlAsync(
                    url: imageUrl,
                    models: "genai",
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatAiGeneratedResponse(response);
            },
            name: "DetectAiGeneratedImage",
            description: "Detect whether an image was AI-generated (by Stable Diffusion, MidJourney, DALL-E, Firefly, Flux, etc.). Returns a confidence score from 0 to 1.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that moderates text for profanity,
    /// personal information, and links.
    /// </summary>
    /// <param name="client">The Sightengine client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsModerateTextTool(
        this SightengineClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, string lang, CancellationToken cancellationToken) =>
            {
                var response = await client.CheckTextAsync(
                    text: text,
                    lang: lang,
                    mode: CheckTextRequestMode.Rules,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTextCheckResponse(response);
            },
            name: "ModerateText",
            description: "Moderate text content for profanity (sexual, discriminatory, insults), personal information (emails, phone numbers, usernames, IPs, SSNs), and links. Provide text and ISO 639-1 language code (e.g., 'en').");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that validates a username for profanity
    /// and misleading content.
    /// </summary>
    /// <param name="client">The Sightengine client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsValidateUsernameTool(
        this SightengineClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string username, string lang, CancellationToken cancellationToken) =>
            {
                var response = await client.CheckTextAsync(
                    text: username,
                    lang: lang,
                    mode: CheckTextRequestMode.Username,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatUsernameCheckResponse(response);
            },
            name: "ValidateUsername",
            description: "Validate a username for profanity, personal info, and misleading content. Provide the username and ISO 639-1 language code (e.g., 'en').");
    }

    private static string FormatImageCheckResponse(ImageCheckResponse response)
    {
        var parts = new List<string> { $"Status: {response.Status}" };

        if (response.Nudity is { } nudity)
        {
            parts.Add($"Nudity: sexual_activity={nudity.SexualActivity:F2}, sexual_display={nudity.SexualDisplay:F2}, erotica={nudity.Erotica:F2}, suggestive={nudity.Suggestive:F2}, none={nudity.None:F2}");
        }

        if (response.Weapon is { } weapon)
        {
            parts.Add($"Weapon: {weapon:F2}");
        }

        if (response.Alcohol is { } alcohol)
        {
            parts.Add($"Alcohol: {alcohol:F2}");
        }

        if (response.Drugs is { } drugs)
        {
            parts.Add($"Drugs: {drugs:F2}");
        }

        if (response.Violence is { } violence)
        {
            parts.Add($"Violence: {violence:F2}");
        }

        if (response.SelfHarm is { } selfHarm)
        {
            parts.Add($"Self-harm: {selfHarm:F2}");
        }

        if (response.Offensive is { } offensive)
        {
            parts.Add($"Offensive: prob={offensive.Prob:F2}");
        }

        if (response.Gore is { } gore)
        {
            parts.Add($"Gore: prob={gore.Prob:F2}");
        }

        if (response.Scam is { } scam)
        {
            parts.Add($"Scam: prob={scam.Prob:F2}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatAiGeneratedResponse(ImageCheckResponse response)
    {
        var parts = new List<string> { $"Status: {response.Status}" };

        if (response.AiGenerated is { } aiGenerated)
        {
            parts.Add($"AI-generated confidence: {aiGenerated:F2}");
            parts.Add(aiGenerated > 0.5 ? "Verdict: Likely AI-generated" : "Verdict: Likely real/authentic");
        }

        return string.Join("\n", parts);
    }

    private static string FormatTextCheckResponse(TextCheckResponse response)
    {
        var parts = new List<string> { $"Status: {response.Status}" };

        if (response.Profanity?.Matches is { Count: > 0 } profanityMatches)
        {
            parts.Add("Profanity matches:");
            foreach (var match in profanityMatches)
            {
                parts.Add($"  - \"{match.Match}\" (type: {match.Type}, intensity: {match.Intensity})");
            }
        }
        else
        {
            parts.Add("Profanity: none detected");
        }

        if (response.Personal?.Matches is { Count: > 0 } personalMatches)
        {
            parts.Add("Personal info matches:");
            foreach (var match in personalMatches)
            {
                parts.Add($"  - \"{match.Match}\" (type: {match.Type})");
            }
        }
        else
        {
            parts.Add("Personal info: none detected");
        }

        if (response.Link?.Matches is { Count: > 0 } linkMatches)
        {
            parts.Add("Link matches:");
            foreach (var match in linkMatches)
            {
                parts.Add($"  - \"{match.Match}\" (type: {match.Type})");
            }
        }
        else
        {
            parts.Add("Links: none detected");
        }

        return string.Join("\n", parts);
    }

    private static string FormatUsernameCheckResponse(TextCheckResponse response)
    {
        var parts = new List<string> { $"Status: {response.Status}" };

        if (response.Profanity?.Matches is { Count: > 0 } profanityMatches)
        {
            parts.Add("Profanity in username:");
            foreach (var match in profanityMatches)
            {
                parts.Add($"  - \"{match.Match}\" (type: {match.Type})");
            }
        }
        else
        {
            parts.Add("Profanity: none detected");
        }

        if (response.Misleading?.Prob is { } misleadingProb)
        {
            parts.Add($"Misleading: prob={misleadingProb:F2}");
        }

        return string.Join("\n", parts);
    }
}
