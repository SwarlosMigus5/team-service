// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByTeamIdQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByTeamIdQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Queries.GetByTeamIdQuery
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Domain.AggregateModels.Team.Repository;
    using TeamService.Domain.Exceptions;

    /// <summary>
    /// <see cref="GetByTeamIdQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetByTeamIdQuery, {Team}"/>
    public class GetByTeamIdQueryHandler : IRequestHandler<GetByTeamIdQuery, Team>
    {
        /// <summary>
        /// The team repository
        /// </summary>
        private readonly ITeamRepository teamRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetByTeamIdQueryHandler"/> class.
        /// </summary>
        /// <param name="teamRepository">The team repository.</param>
        public GetByTeamIdQueryHandler(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        /// <exception cref="NotFoundException">The team with id {request.TeamId} wasn't found.</exception>
        public async Task<Team> Handle(GetByTeamIdQuery request, CancellationToken cancellationToken)
        {
            Team team = await this.teamRepository.GetAsync(request.TeamId, cancellationToken);

            if (team is null)
            {
                throw new NotFoundException($"The team with id {request.TeamId} wasn't found.");
            }

            return team;
        }
    }
}