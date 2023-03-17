// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamAcronymBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ITeamAcronymBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.AggregateModels.Team.Builder.TeamAcronymBuilder
{
    /// <summary>
    /// <see cref="ITeamAcronymBuilder"/>
    /// </summary>
    public interface ITeamAcronymBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        TeamAcronym Build();

        /// <summary>
        /// Creates new teamacronym.
        /// </summary>
        /// <param name="acronym">The acronym.</param>
        /// <returns></returns>
        ITeamAcronymBuilder NewTeamAcronym(string acronym);
    }
}