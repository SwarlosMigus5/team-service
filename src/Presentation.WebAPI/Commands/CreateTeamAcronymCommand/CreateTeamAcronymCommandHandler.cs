// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateTeamAcronymCommandHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateTeamAcronymCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.CreateTeamAcronymCommand
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Domain.AggregateModels.Team.Builder.TeamAcronymBuilder;
    using TeamService.Domain.AggregateModels.Team.Repository;
    using TeamService.Domain.Exceptions;

    /// <summary>
    /// <see cref="CreateTeamAcronymCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{CreateTeamAcronymCommand, TeamAcronym}"/>
    public class CreateTeamAcronymCommandHandler : IRequestHandler<CreateTeamAcronymCommand, TeamAcronym>
    {
        /// <summary>
        /// The team acronym builder
        /// </summary>
        private readonly ITeamAcronymBuilder teamAcronymBuilder;

        /// <summary>
        /// The team repository
        /// </summary>
        private readonly ITeamRepository teamRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamAcronymCommandHandler"/> class.
        /// </summary>
        /// <param name="teamAcronymBuilder">The team acronym builder.</param>
        /// <param name="teamRepository">The team repository.</param>
        public CreateTeamAcronymCommandHandler(
            ITeamAcronymBuilder teamAcronymBuilder,
            ITeamRepository teamRepository)
        {
            this.teamAcronymBuilder = teamAcronymBuilder;
            this.teamRepository = teamRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        /// <exception cref="NotFoundException">The team with id {request.TeamId} wasn't found.</exception>
        public async Task<TeamAcronym> Handle(CreateTeamAcronymCommand request, CancellationToken cancellationToken)
        {
            Team team = await this.teamRepository.GetAsync(request.TeamId, cancellationToken);

            if (team is null)
            {
                throw new NotFoundException($"The team with id {request.TeamId} wasn't found.");
            }

            TeamAcronym teamAcronym = this.teamAcronymBuilder
                .NewTeamAcronym(request.Acronym)
                .Build();

            team.AddAcronym(teamAcronym);

            await this.teamRepository.Update(team, cancellationToken);

            await this.teamRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return teamAcronym;
        }
    }
}