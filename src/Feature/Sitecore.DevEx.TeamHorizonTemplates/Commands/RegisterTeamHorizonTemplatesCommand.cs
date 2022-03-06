using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using Sitecore.DevEx.TeamHorizonTemplates.Confirmations;
using Sitecore.DevEx.TeamHorizonTemplates.Tasks;
using System;
using System.CommandLine;
using System.Threading.Tasks;

namespace Sitecore.DevEx.TeamHorizonTemplates.Commands
{
    internal class RegisterTeamHorizonTemplatesCommand : SubcommandBase<RegisterTeamHorizonTemplatesTask, RegisterTeamHorizonTemplatesArgs>
    {
        private readonly IConfirmation _confirmation;
        public const string CommandName = "start";

        public RegisterTeamHorizonTemplatesCommand(IServiceProvider container, IConfirmation confirmation)
          : base("start", "Registers a task to run TeamHorizon Templates", container)
        {
            this._confirmation = confirmation;
            ((Command)this).AddOption(CommonArgOptions.CommandId);
            ((Command)this).AddOption(CommonArgOptions.Config);
            ((Command)this).AddOption(CommonArgOptions.EnvironmentName);
            ((Command)this).AddOption(CommonArgOptions.Verbose);
            ((Command)this).AddOption(CommonArgOptions.Trace);
        }

        protected override async Task<int> Handle(RegisterTeamHorizonTemplatesTask task, RegisterTeamHorizonTemplatesArgs args)
        {
            if (args.Confirm)
            {
                await task.Execute((RegisterTeamHorizonTemplatesOptions)args, args.CommandId).ConfigureAwait(false);
            }
            return 0;
        }
    }
}
