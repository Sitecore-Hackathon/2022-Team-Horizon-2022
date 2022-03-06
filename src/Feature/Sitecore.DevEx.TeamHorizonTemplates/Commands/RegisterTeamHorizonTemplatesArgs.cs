using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using Sitecore.DevEx.TeamHorizonTemplates.Tasks;

namespace Sitecore.DevEx.TeamHorizonTemplates.Commands
{
    internal class RegisterTeamHorizonTemplatesArgs : RegisterTeamHorizonTemplatesOptions, IVerbosityArgs
    {
        public bool Verbose { get; set; }

        public bool Trace { get; set; }

        public bool Confirm { get; set; }
    }
}
