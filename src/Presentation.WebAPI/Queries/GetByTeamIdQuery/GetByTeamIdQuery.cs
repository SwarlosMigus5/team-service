// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByTeamIdQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByTeamIdQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Queries.GetByTeamIdQuery
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;

    /// <summary>
    /// <see cref="GetByTeamIdQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{Team}"/>
    public class GetByTeamIdQuery : IRequest<Team>
    {
        /// <summary>
        /// Gets the team identifier.
        /// </summary>
        /// <value>The team identifier.</value>
        public Guid TeamId { get; init; }
    }
}