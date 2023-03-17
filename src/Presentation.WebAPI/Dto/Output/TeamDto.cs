// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Dto.Output
{
    /// <summary>
    /// <see cref="TeamDto"/>
    /// </summary>
    public class TeamDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDto"/> class.
        /// </summary>
        public TeamDto()
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
        /// Gets the uu identifier.
        /// </summary>
        /// <value>The uu identifier.</value>
        public Guid UUId { get; init; }
    }
}