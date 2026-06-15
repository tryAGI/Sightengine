#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Sightengine.CLI.Commands;

internal static partial class SubmitFeedbackCommandApiCommand
{
    private static Option<string?> Url { get; } = new(
        name: @"--url")
    {
        Description = @"Public URL to the image (use this OR media).",
    };

    private static Option<byte[]?> Media { get; } = new(
        name: @"--media")
    {
        Description = @"The image file (use this OR url).",
    };

    private static Option<string?> Medianame { get; } = new(
        name: @"--medianame")
    {
        Description = @"The image file (use this OR url).",
    };

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model that classified the image.
Available: nudity, gore, weapon, drugs, violence,
alcohol, offensive, self-harm, scam, genai.
",
        Required = true,
    };

    private static Option<string> Class { get; } = new(
        name: @"--class")
    {
        Description = @"The expected/correct classification result.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Sightengine.FeedbackResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Sightengine.FeedbackResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"submit-feedback", @"Submit Feedback
Submit moderation feedback to improve model accuracy.
Feedback submissions are free and do not count as operations.
The image is used to continuously improve the specified model.
");
                        command.Options.Add(Url);
                        command.Options.Add(Media);
                        command.Options.Add(Medianame);
                        command.Options.Add(Model);
                        command.Options.Add(Class);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Sightengine.SubmitFeedbackRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Sightengine.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var url = CliRuntime.WasSpecified(parseResult, Url) ? parseResult.GetValue(Url) : (__requestBase is { } __UrlBaseValue ? __UrlBaseValue.Url : default);
                        var media = CliRuntime.WasSpecified(parseResult, Media) ? parseResult.GetValue(Media) : (__requestBase is { } __MediaBaseValue ? __MediaBaseValue.Media : default);
                        var medianame = CliRuntime.WasSpecified(parseResult, Medianame) ? parseResult.GetValue(Medianame) : (__requestBase is { } __MedianameBaseValue ? __MedianameBaseValue.Medianame : default);
                        var model = parseResult.GetRequiredValue(Model);
                        var @class = parseResult.GetRequiredValue(Class);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubmitFeedbackAsync(
                                    url: url,
                                    media: media,
                                    medianame: medianame,
                                    model: model,
                                    @class: @class,
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