// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteTeamAcronymCommandHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// DeleteTeamAcronymCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.DeleteTeamAcronymCommand
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team.Repository;
    using TeamService.Domain.Exceptions;

    /// <summary>
    /// <see cref="DeleteTeamAcronymCommandHandler"/>
    /// </summary>
    /// <seealso cref="INotificationHandler{DeleteTeamAcronymCommand}"/>
    public class DeleteTeamAcronymCommandHandler : INotificationHandler<DeleteTeamAcronymCommand>
    {
        /// <summary>
        /// The team acronym repository
        /// </summary>
        private readonly ITeamAcronymRepository teamAcronymRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTeamAcronymCommandHandler"/> class.
        /// </summary>
        /// <param name="teamAcronymRepository">The team acronym repository.</param>
        public DeleteTeamAcronymCommandHandler(ITeamAcronymRepository teamAcronymRepository)
        {
            this.teamAcronymRepository = teamAcronymRepository;
        }

        /// <summary>
        /// Handles a notification
        /// </summary>
        /// <param name="notification">The notification</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="NotFoundException">
        /// The team acronym with id {notification.TeamAcronymId} wasn't found.
        /// </exception>
        public async Task Handle(DeleteTeamAcronymCommand notification, CancellationToken cancellationToken)
        {
            var teamAcronym = await this.teamAcronymRepository.GetAsync(notification.TeamAcronymId, cancellationToken);

            if (teamAcronym is null)
            {
                throw new NotFoundException($"The team acronym with id {notification.TeamAcronymId} wasn't found.");
            }

            await this.teamAcronymRepository.Remove(teamAcronym, cancellationToken);

            await this.teamAcronymRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}