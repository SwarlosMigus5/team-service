// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteTeamCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// DeleteTeamCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.DeleteTeamCommand
{
    using MediatR;

    /// <summary>
    /// <see cref="DeleteTeamCommand"/>
    /// </summary>
    /// <seealso cref="INotification"/>
    public class DeleteTeamCommand : INotification
    {
        /// <summary>
        /// Gets or sets the team identifier.
        /// </summary>
        /// <value>The team identifier.</value>
        public Guid TeamId { get; init; }
    }
}