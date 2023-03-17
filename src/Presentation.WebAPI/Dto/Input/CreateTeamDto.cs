// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateTeamDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateTeamDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Dto.Input
{
    /// <summary>
    /// <see cref="CreateTeamDto"/>
    /// </summary>
    public class CreateTeamDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamDto"/> class.
        /// </summary>
        public CreateTeamDto()
        {
            this.ShortName = string.Empty;
            this.Name = string.Empty;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets or sets the acronym.
        /// </summary>
        /// <value>The acronym.</value>
        public string ShortName { get; init; }
    }
}