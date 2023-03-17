// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamAcronymRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ITeamAcronymRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.AggregateModels.Team.Repository
{
    using TeamService.Domain.SeedWork;

    /// <summary>
    /// <see cref="ITeamAcronymRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{TeamAcronym}"/>
    public interface ITeamAcronymRepository : IRepository<TeamAcronym>
    {
    }
}