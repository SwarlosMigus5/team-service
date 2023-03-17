// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByTeamAcronymIdDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByTeamAcronymIdDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Dto.Input
{
    /// <summary>
    /// <see cref="GetByTeamAcronymIdDto"/>
    /// </summary>
    public class GetByTeamAcronymIdDto
    {
        /// <summary>
        /// Gets the team acronym identifier.
        /// </summary>
        /// <value>The team acronym identifier.</value>
        public Guid TeamAcronymId { get; init; }
    }
}