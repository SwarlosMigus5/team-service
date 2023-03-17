// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetTeamAcronymByTeamIdQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetTeamAcronymByTeamIdQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Queries.GetTeamAcronymByTeamIdQuery
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Domain.AggregateModels.Team.Repository;
    using TeamService.Domain.Exceptions;

    /// <summary>
    /// <see cref="GetTeamAcronymByTeamIdQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetTeamAcronymByTeamIdQuery, IEnumerable{TeamAcronym}}"/>
    public class GetTeamAcronymByTeamIdQueryHandler : IRequestHandler<GetTeamAcronymByTeamIdQuery, IEnumerable<TeamAcronym>>
    {
        /// <summary>
        /// The team repository
        /// </summary>
        private readonly ITeamRepository teamRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamAcronymByTeamIdQueryHandler"/> class.
        /// </summary>
        /// <param name="teamRepository">The team repository.</param>
        public GetTeamAcronymByTeamIdQueryHandler(ITeamRepository teamRepository)
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
        public async Task<IEnumerable<TeamAcronym>> Handle(GetTeamAcronymByTeamIdQuery request, CancellationToken cancellationToken)
        {
            Team team = await this.teamRepository.GetAsync(request.TeamId, cancellationToken);

            if (team is null)
            {
                throw new NotFoundException($"The team with id {request.TeamId} wasn't found.");
            }

            return team.Acronyms;
        }
    }
}