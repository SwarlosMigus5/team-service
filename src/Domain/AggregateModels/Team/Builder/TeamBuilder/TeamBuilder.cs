// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.AggregateModels.Team.Builder.TeamBuilder
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="TeamBuilder"/>
    /// </summary>
    /// <seealso cref="ITeamBuilder"/>
    internal class TeamBuilder : ITeamBuilder
    {
        /// <summary>
        /// The team
        /// </summary>
        private Team team;

        /// <summary>
        /// Adds the team acronym.
        /// </summary>
        /// <param name="acronyms">The acronyms.</param>
        /// <returns></returns>
        public ITeamBuilder AddTeamAcronym(List<TeamAcronym> acronyms)
        {
            foreach (var acronym in acronyms)
            {
                this.team.AddAcronym(acronym);
            }

            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Team Build()
        {
            return this.team;
        }

        /// <summary>
        /// Creates new team.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="acronym">The acronym.</param>
        /// <returns></returns>
        public ITeamBuilder NewTeam(string name, string acronym)
        {
            this.team = new Team(name, acronym);

            return this;
        }
    }
}