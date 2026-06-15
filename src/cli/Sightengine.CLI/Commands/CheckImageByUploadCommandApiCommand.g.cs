#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Sightengine.CLI.Commands;

internal static partial class CheckImageByUploadCommandApiCommand
{
    private static Option<byte[]> Media { get; } = new(
        name: @"--media")
    {
        Description = @"The image file to analyze.",
        Required = true,
    };

    private static Option<string> Medianame { get; } = new(
        name: @"--medianame")
    {
        Description = @"The image file to analyze.",
        Required = true,
    };

    private static Option<string> Models { get; } = new(
        name: @"--models")
    {
        Description = @"Comma-separated list of detection models to apply.
Available models: nudity-2.1, gore-2.0, weapon, drugs, violence,
alcohol, offensive, self-harm, scam, face-attributes, text-content,
qr-content, genai, type, quality.
",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Sightengine.ImageCheckResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Sightengine.ImageCheckResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"check-image-by-upload", @"Check Image (Upload)
Moderate an uploaded image using one or more detection models.
Supports nudity, violence, gore, weapons, drugs, alcohol, offensive content,
self-harm, scam detection, face analysis, text-in-image (OCR), QR codes,
AI-generated image detection, image type, and quality assessment.
");
                        command.Options.Add(Media);
                        command.Options.Add(Medianame);
                        command.Options.Add(Models);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var media = parseResult.GetRequiredValue(Media);
                        var medianame = parseResult.GetRequiredValue(Medianame);
                        var models = parseResult.GetRequiredValue(Models);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CheckImageByUploadAsync(
                                    media: media,
                                    medianame: medianame,
                                    models: models,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Sightengine.SourceGenerationContext.Default,
                                        @"Faces",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Sightengine.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}