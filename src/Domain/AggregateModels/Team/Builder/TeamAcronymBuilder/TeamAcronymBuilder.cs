// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamAcronymBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamAcronymBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.AggregateModels.Team.Builder.TeamAcronymBuilder
{
    /// <summary>
    /// <see cref="TeamAcronymBuilder"/>
    /// </summary>
    /// <seealso cref="ITeamAcronymBuilder"/>
    internal class TeamAcronymBuilder : ITeamAcronymBuilder
    {
        /// <summary>
        /// The team acronym
        /// </summary>
        private TeamAcronym teamAcronym;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public TeamAcronym Build()
        {
            return this.teamAcronym;
        }

        /// <summary>
        /// Creates new teamacronym.
        /// </summary>
        /// <param name="acronym">The acronym.</param>
        /// <returns></returns>
        public ITeamAcronymBuilder NewTeamAcronym(string acronym)
        {
            this.teamAcronym = new TeamAcronym(acronym);

            return this;
        }
    }
}