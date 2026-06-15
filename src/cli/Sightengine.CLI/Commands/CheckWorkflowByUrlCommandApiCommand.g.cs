#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Sightengine.CLI.Commands;

internal static partial class CheckWorkflowByUrlCommandApiCommand
{
    private static Option<string> Url { get; } = new(
        name: @"--url")
    {
        Description = @"Public URL of the image to analyze.",
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
        var command = new Command(@"check-workflow-by-url", @"Check Image with Workflow (URL)
Moderate an image by URL using a pre-configured workflow.
Workflows define custom rules and actions from the dashboard.
");
                        command.Options.Add(Url);
                        command.Options.Add(Workflow);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var url = parseResult.GetRequiredValue(Url);
                        var workflow = parseResult.GetRequiredValue(Workflow);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CheckWorkflowByUrlAsync(
                                    url: url,
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