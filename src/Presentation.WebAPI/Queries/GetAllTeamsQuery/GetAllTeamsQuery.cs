// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllTeamsQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetAllTeamsQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Queries.GetAllTeamsQuery
{
    using MediatR;
    using TeamService.Domain.AggregateModels.Team;

    /// <summary>
    /// <see cref="GetAllTeamsQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{IEnumerable{Team}}"/>
    public class GetAllTeamsQuery : IRequest<IEnumerable<Team>>
    {
    }
}