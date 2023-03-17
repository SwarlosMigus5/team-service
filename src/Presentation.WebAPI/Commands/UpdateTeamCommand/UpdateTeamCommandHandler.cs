// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateTeamCommandHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// UpdateTeamCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.UpdateTeamCommand
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Domain.AggregateModels.Team.Repository;
    using TeamService.Domain.Exceptions;

    /// <summary>
    /// <see cref="UpdateTeamCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{UpdateTeamCommand, Team}"/>
    public class UpdateTeamCommandHandler : IRequestHandler<UpdateTeamCommand, Team>
    {
        /// <summary>
        /// The team repository
        /// </summary>
        private readonly ITeamRepository teamRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamCommandHandler"/> class.
        /// </summary>
        /// <param name="teamRepository">The team repository.</param>
        public UpdateTeamCommandHandler(ITeamRepository teamRepository)
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
        public async Task<Team> Handle(UpdateTeamCommand request, CancellationToken cancellationToken)
        {
            Team team = await this.teamRepository.GetAsync(request.TeamId, cancellationToken);

            if (team is null)
            {
                throw new NotFoundException($"The team with id {request.TeamId} wasn't found.");
            }

            team.Update(request.Name, request.ShortName);

            await this.teamRepository.Update(team, cancellationToken);

            await this.teamRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return team;
        }
    }
}