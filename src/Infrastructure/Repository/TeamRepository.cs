// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Infrastructure.Repository
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Domain.AggregateModels.Team.Repository;

    /// <summary>
    /// <see cref="TeamRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Team}"/>
    /// <seealso cref="ITeamRepository"/>
    internal class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TeamRepository(TeamServiceDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the by name asynchronous.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<Team> GetByNameAsync(string name, CancellationToken cancellationToken)
        {
            return await this.Entities.SingleOrDefaultAsync(t => t.Name == name, cancellationToken);
        }
    }
}