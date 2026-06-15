#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Sightengine.CLI.Commands;

internal static partial class CheckWorkflowByUploadCommandApiCommand
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

    private static Option<string> Workflow { get; } = new(
        name: @"--workflow")
    {
        Description = @"Workflow ID from the Sightengine dashboard.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Sightengine.WorkflowCheckResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Sightengine.WorkflowCheckResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"check-workflow-by-upload", @"Check Image with Workflow (Upload)
Moderate an uploaded image using a pre-configured workflow.
Workflows define custom rules and actions from the dashboard.
");
                        command.Options.Add(Media);
                        command.Options.Add(Medianame);
                        command.Options.Add(Workflow);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var media = parseResult.GetRequiredValue(Media);
                        var medianame = parseResult.GetRequiredValue(Medianame);
                        var workflow = parseResult.GetRequiredValue(Workflow);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CheckWorkflowByUploadAsync(
                                    media: media,
                                    medianame: medianame,
                                    workflow: workflow,
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