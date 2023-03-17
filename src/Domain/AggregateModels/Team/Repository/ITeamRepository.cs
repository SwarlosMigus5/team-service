// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ITeamRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.AggregateModels.Team.Repository
{
    using System.Threading;
    using System.Threading.Tasks;
    using TeamService.Domain.SeedWork;

    /// <summary>
    /// <see cref="ITeamRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Team}"/>
    public interface ITeamRepository : IRepository<Team>
    {
        /// <summary>
        /// Gets the by name asynchronous.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<Team> GetByNameAsync(string name, CancellationToken cancellationToken);
    }
}