// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateTeamCommandHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateTeamCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.CreateTeamCommand
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Domain.AggregateModels.Team.Builder.TeamBuilder;
    using TeamService.Domain.AggregateModels.Team.Repository;
    using TeamService.Domain.Exceptions;

    /// <summary>
    /// <see cref="CreateTeamCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{CreateTeamCommand, Team}"/>
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, Team>
    {
        /// <summary>
        /// The team builder
        /// </summary>
        private readonly ITeamBuilder teamBuilder;

        /// <summary>
        /// The team repository
        /// </summary>
        private readonly ITeamRepository teamRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamCommandHandler"/> class.
        /// </summary>
        /// <param name="teamRepository">The team repository.</param>
        /// <param name="teamBuilder">The team builder.</param>
        public CreateTeamCommandHandler(
            ITeamRepository teamRepository,
            ITeamBuilder teamBuilder)
        {
            this.teamRepository = teamRepository;
            this.teamBuilder = teamBuilder;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        /// <exception cref="DuplicatedException">The team with name {request.Name} is duplicated.</exception>
        public async Task<Team> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            Team team = await this.teamRepository.GetByNameAsync(request.Name, cancellationToken);

            if (team is not null)
            {
                throw new DuplicatedException($"The team with name {request.Name} is duplicated.");
            }

            team = this.teamBuilder
                .NewTeam(request.Name, request.ShortName)
                .Build();

            await this.teamRepository.AddAsync(team, cancellationToken);

            await this.teamRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return team;
        }
    }
}