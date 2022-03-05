using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using System.CommandLine;

namespace Sitecore.DevEx.TeamHorizonTemplates
{
    public class TeamHorizonTemplatesCommand : Command, ISubcommand
    {
        public const string CommandName = "teamhorizontemplates";

        public TeamHorizonTemplatesCommand()
          : base("teamhorizontemplates", "Manage teamhorizontemplates commands.")
        {
        }
    }
}
