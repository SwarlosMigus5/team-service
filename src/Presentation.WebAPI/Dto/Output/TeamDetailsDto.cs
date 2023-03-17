// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamDetailsDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Dto.Output
{
    /// <summary>
    /// <see cref="TeamDetailsDto"/>
    /// </summary>
    public class TeamDetailsDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDetailsDto"/> class.
        /// </summary>
        public TeamDetailsDto()
        {
            this.Acronyms = new();
            this.ShortName = string.Empty;
            this.Name = string.Empty;
        }

        /// <summary>
        /// Gets the acronyms.
        /// </summary>
        /// <value>The acronyms.</value>
        public List<TeamAcronymDetailsDto> Acronyms { get; init; }

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