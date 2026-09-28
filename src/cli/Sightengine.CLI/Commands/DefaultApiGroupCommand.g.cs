#nullable enable

using System.CommandLine;

namespace Sightengine.CLI.Commands;

internal static partial class DefaultApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CheckImageByUploadCommandApiCommand.Create());
                         command.Subcommands.Add(CheckImageByUrlCommandApiCommand.Create());
                         command.Subcommands.Add(CheckTextCommandApiCommand.Create());
                         command.Subcommands.Add(CheckVideoAsyncCommandApiCommand.Create());
                         command.Subcommands.Add(CheckVideoSyncCommandApiCommand.Create());
                         command.Subcommands.Add(CheckWorkflowByUploadCommandApiCommand.Create());
                         command.Subcommands.Add(CheckWorkflowByUrlCommandApiCommand.Create());
                         command.Subcommands.Add(SubmitFeedbackCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}