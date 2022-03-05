using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Devex.Client.Cli.Extensibility;
using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using System;
using System.Collections.Generic;
using System.CommandLine;

namespace Sitecore.DevEx.TeamHorizonTemplates
{
    public class RegisterExtension : ISitecoreCliExtension
    {
        public IEnumerable<ISubcommand> AddCommands(IServiceProvider container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));
            TeamHorizonTemplatesCommand teamHorizonTemplatesCommand = new TeamHorizonTemplatesCommand();
            //TODO add commands here
            return (IEnumerable<ISubcommand>)new ISubcommand[1]
            {
                (ISubcommand) teamHorizonTemplatesCommand
            };
        }

        public void AddConfiguration(IConfigurationBuilder configBuilder)
        {
            throw new NotImplementedException();
        }

        public void AddServices(IServiceCollection serviceCollection)
        {
            throw new NotImplementedException();
        }
    }
}
