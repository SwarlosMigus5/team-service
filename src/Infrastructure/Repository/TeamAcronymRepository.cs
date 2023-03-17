// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamAcronymRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamAcronymRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Infrastructure.Repository
{
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Domain.AggregateModels.Team.Repository;

    /// <summary>
    /// <see cref="TeamAcronymRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{TeamAcronym}"/>
    /// <seealso cref="ITeamAcronymRepository"/>
    internal class TeamAcronymRepository : GenericRepository<TeamAcronym>, ITeamAcronymRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamAcronymRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TeamAcronymRepository(TeamServiceDBContext context)
            : base(context)
        {
        }
    }
}