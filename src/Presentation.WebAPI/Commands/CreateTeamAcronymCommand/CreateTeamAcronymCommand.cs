// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateTeamAcronymCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateTeamAcronymCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.CreateTeamAcronymCommand
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;

    /// <summary>
    /// <see cref="CreateTeamAcronymCommand"/>
    /// </summary>
    /// <seealso cref="TeamAcronym"/>
    /// <seealso cref="IRequest{TeamAcronym}"/>
    public class CreateTeamAcronymCommand : IRequest<TeamAcronym>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamAcronymCommand"/> class.
        /// </summary>
        public CreateTeamAcronymCommand()
        {
            this.Acronym = string.Empty;
        }

        /// <summary>
        /// Gets the acronym.
        /// </summary>
        /// <value>The acronym.</value>
        public string Acronym { get; init; }

        /// <summary>
        /// Gets the team identifier.
        /// </summary>
        /// <value>The team identifier.</value>
        public Guid TeamId { get; init; }
    }
}