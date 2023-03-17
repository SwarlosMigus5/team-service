// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateTeamCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// UpdateTeamCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.UpdateTeamCommand
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;

    /// <summary>
    /// <see cref="UpdateTeamCommand"/>
    /// </summary>
    /// <seealso cref="IRequest{Team}"/>
    public class UpdateTeamCommand : IRequest<Team>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamCommand"/> class.
        /// </summary>
        public UpdateTeamCommand()
        {
            this.Name = string.Empty;
            this.ShortName = string.Empty;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets the short name.
        /// </summary>
        /// <value>The short name.</value>
        public string ShortName { get; init; }

        /// <summary>
        /// Gets the team identifier.
        /// </summary>
        /// <value>The team identifier.</value>
        public Guid TeamId { get; init; }
    }
}