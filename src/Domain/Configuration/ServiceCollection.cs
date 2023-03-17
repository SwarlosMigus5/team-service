// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.Configuration
{
    using Microsoft.Extensions.DependencyInjection;
    using TeamService.Domain.AggregateModels.Team.Builder.TeamAcronymBuilder;
    using TeamService.Domain.AggregateModels.Team.Builder.TeamBuilder;

    /// <summary>
    /// <see cref="ServiceCollection"/>
    /// </summary>
    public static class ServiceCollection
    {
        /// <summary>
        /// Registers the domain services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ITeamBuilder, TeamBuilder>();
            services.AddScoped<ITeamAcronymBuilder, TeamAcronymBuilder>();
        }
    }
}