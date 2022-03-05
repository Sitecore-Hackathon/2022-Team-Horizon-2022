using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Devex.Client.Cli.Extensibility;
using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using System;
using System.Collections.Generic;

namespace Sitecore.DevEx.TeamHorizonTemplates
{
    public class RegisterExtension : ISitecoreCliExtension
    {
        public IEnumerable<ISubcommand> AddCommands(IServiceProvider container)
        {
            throw new NotImplementedException();
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
