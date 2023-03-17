// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateTeamAcronymDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateTeamAcronymDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Dto.Input
{
    /// <summary>
    /// <see cref="CreateTeamAcronymDto"/>
    /// </summary>
    public class CreateTeamAcronymDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamAcronymDto"/> class.
        /// </summary>
        public CreateTeamAcronymDto()
        {
            this.Acronym = string.Empty;
        }

        /// <summary>
        /// Gets the acronym.
        /// </summary>
        /// <value>The acronym.</value>
        public string Acronym { get; init; }
    }
}