#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Sightengine.CLI.Commands;

internal static partial class CheckVideoSyncCommandApiCommand
{
    private static Option<byte[]?> Media { get; } = new(
        name: @"--media")
    {
        Description = @"The video file to analyze (use this OR stream_url).",
    };

    private static Option<string?> Medianame { get; } = new(
        name: @"--medianame")
    {
        Description = @"The video file to analyze (use this OR stream_url).",
    };

    private static Option<string?> StreamUrl { get; } = new(
        name: @"--stream-url")
    {
        Description = @"Public URL of the video (use this OR media).",
    };

    private static Option<string> Models { get; } = new(
        name: @"--models")
    {
        Description = @"Comma-separated list of detection models.
Available: nudity-2.1, gore-2.0, weapon, drugs, violence,
alcohol, offensive, self-harm, scam.
",
        Required = true,
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Sightengine.VideoCheckSyncResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Sightengine.VideoCheckSyncResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"check-video-sync", @"Check Video (Synchronous)
Moderate a video synchronously (must be under 60 seconds).
Submit either a raw video file or a public URL.
");
                        command.Options.Add(Media);
                        command.Options.Add(Medianame);
                        command.Options.Add(StreamUrl);
                        command.Options.Add(Models);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Sightengine.CheckVideoSyncRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Sightengine.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var media = CliRuntime.WasSpecified(parseResult, Media) ? parseResult.GetValue(Media) : __requestBase is not null ? __requestBase.Media : default;
                        var medianame = CliRuntime.WasSpecified(parseResult, Medianame) ? parseResult.GetValue(Medianame) : __requestBase is not null ? __requestBase.Medianame : default;
                        var streamUrl = CliRuntime.WasSpecified(parseResult, StreamUrl) ? parseResult.GetValue(StreamUrl) : __requestBase is not null ? __requestBase.StreamUrl : default;
                        var models = parseResult.GetRequiredValue(Models);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CheckVideoSyncAsync(
                                    media: media,
                                    medianame: medianame,
                                    streamUrl: streamUrl,
                                    models: models,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Sightengine.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}