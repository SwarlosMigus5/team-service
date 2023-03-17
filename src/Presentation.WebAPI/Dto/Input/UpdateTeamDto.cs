// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateTeamDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// UpdateTeamDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Dto.Input
{
    /// <summary>
    /// <see cref="UpdateTeamDto"/>
    /// </summary>
    public class UpdateTeamDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamDto"/> class.
        /// </summary>
        public UpdateTeamDto()
        {
            this.Name = string.Empty;
            this.ShortName = string.Empty;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>The short name.</value>
        public string ShortName { get; init; }
    }
}