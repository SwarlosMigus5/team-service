// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllTeamsQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetAllTeamsQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Queries.GetAllTeamsQuery
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Domain.AggregateModels.Team.Repository;

    /// <summary>
    /// <see cref="GetAllTeamsQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetAllTeamsQuery, IEnumerable{Team}}"/>
    public class GetAllTeamsQueryHandler : IRequestHandler<GetAllTeamsQuery, IEnumerable<Team>>
    {
        /// <summary>
        /// The team repository
        /// </summary>
        private readonly ITeamRepository teamRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllTeamsQueryHandler"/> class.
        /// </summary>
        /// <param name="teamRepository">The team repository.</param>
        public GetAllTeamsQueryHandler(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        public async Task<IEnumerable<Team>> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
        {
            return await this.teamRepository.GetAllAsync(cancellationToken);
        }
    }
}