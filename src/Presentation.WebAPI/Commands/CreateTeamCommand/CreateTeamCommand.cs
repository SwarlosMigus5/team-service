// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateTeamCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateTeamCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.CreateTeamCommand
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;

    /// <summary>
    /// <see cref="CreateTeamCommand"/>
    /// </summary>
    /// <seealso cref="IRequest{Team}"/>
    public class CreateTeamCommand : IRequest<Team>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamCommand"/> class.
        /// </summary>
        public CreateTeamCommand()
        {
            this.ShortName = string.Empty;
            this.Name = string.Empty;
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
    }
}