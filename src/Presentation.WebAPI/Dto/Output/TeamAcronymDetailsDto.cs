// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamAcronymDetailsDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamAcronymDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Dto.Output
{
    /// <summary>
    /// <see cref="TeamAcronymDetailsDto"/>
    /// </summary>
    public class TeamAcronymDetailsDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamAcronymDetailsDto"/> class.
        /// </summary>
        public TeamAcronymDetailsDto()
        {
            this.Acronym = string.Empty;
        }

        /// <summary>
        /// Gets the acronym.
        /// </summary>
        /// <value>The acronym.</value>
        public string Acronym { get; init; }

        /// <summary>
        /// Gets the uu identifier.
        /// </summary>
        /// <value>The uu identifier.</value>
        public Guid UUId { get; init; }
    }
}