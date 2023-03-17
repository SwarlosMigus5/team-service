// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ITeamBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.AggregateModels.Team.Builder.TeamBuilder
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="ITeamBuilder"/>
    /// </summary>
    public interface ITeamBuilder
    {
        /// <summary>
        /// Adds the team acronym.
        /// </summary>
        /// <param name="acronyms">The acronyms.</param>
        /// <returns></returns>
        ITeamBuilder AddTeamAcronym(List<TeamAcronym> acronyms);

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Team Build();

        /// <summary>
        /// Creates new team.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="acronym">The acronym.</param>
        /// <returns></returns>
        ITeamBuilder NewTeam(string name, string acronym);
    }
}