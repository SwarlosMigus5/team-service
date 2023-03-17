// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteTeamCommandHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// DeleteTeamCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.DeleteTeamCommand
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team.Repository;
    using TeamService.Domain.Exceptions;

    /// <summary>
    /// <see cref="DeleteTeamCommandHandler"/>
    /// </summary>
    /// <seealso cref="INotificationHandler{DeleteTeamCommand}"/>
    public class DeleteTeamCommandHandler : INotificationHandler<DeleteTeamCommand>
    {
        /// <summary>
        /// The team repository
        /// </summary>
        private readonly ITeamRepository teamRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTeamCommandHandler"/> class.
        /// </summary>
        /// <param name="teamRepository">The team repository.</param>
        public DeleteTeamCommandHandler(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        /// <summary>
        /// Handles a notification
        /// </summary>
        /// <param name="notification">The notification</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="NotFoundException">
        /// The team with id {notification.TeamId} wasn't found.
        /// </exception>
        public async Task Handle(DeleteTeamCommand notification, CancellationToken cancellationToken)
        {
            var team = await this.teamRepository.GetAsync(notification.TeamId, cancellationToken);

            if (team is null)
            {
                throw new NotFoundException($"The team with id {notification.TeamId} wasn't found.");
            }

            await this.teamRepository.Remove(team, cancellationToken);

            await this.teamRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}