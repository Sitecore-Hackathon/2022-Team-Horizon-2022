using Microsoft.Extensions.Logging;
using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using Sitecore.DevEx.Client.Tasks;
using Sitecore.DevEx.Configuration;
using Sitecore.DevEx.Configuration.Models;
using System;
using System.Threading.Tasks;

namespace Sitecore.DevEx.TeamHorizonTemplates.Tasks
{
    public class RegisterTeamHorizonTemplatesTask

    {
        private readonly IRootConfigurationManager _rootConfigurationManager;
        private readonly ISubcommand _runCommand;

        public RegisterTeamHorizonTemplatesTask(
          IRootConfigurationManager rootConfigurationManager,
          ILoggerFactory loggerFactory,
          ISubcommand runCommand)
        {
            this._rootConfigurationManager = rootConfigurationManager ?? throw new ArgumentNullException(nameof(rootConfigurationManager));
            _runCommand = runCommand;
        }

        public async Task Execute(RegisterTeamHorizonTemplatesOptions options, string id)
        {
            ((TaskOptionsBase)options).Validate();
            EnvironmentConfiguration environmentConfiguration;
            if (!(await this._rootConfigurationManager.ResolveRootConfiguration(options.Config)).Environments.TryGetValue(options.EnvironmentName, out environmentConfiguration))
                throw new InvalidConfigurationException("Environment " + options.EnvironmentName + " was not defined. Use the login command to define it.");

            //TODO
        }
    }
}