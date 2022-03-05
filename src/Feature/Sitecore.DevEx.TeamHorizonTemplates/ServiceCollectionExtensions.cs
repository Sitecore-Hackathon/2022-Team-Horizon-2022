using Microsoft.Extensions.DependencyInjection;
using Sitecore.DevEx.TeamHorizonTemplates.Commands;
using System;

namespace Sitecore.DevEx.TeamHorizonTemplates
{
    internal static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTeamHorizonTemplatesServices(
      this IServiceCollection serviceCollection)
        {
            return serviceCollection != null ? serviceCollection.AddSingleton<RegisterTeamHorizonTemplatesCommand>(): throw new ArgumentNullException(nameof(serviceCollection));
        }
    }
}
