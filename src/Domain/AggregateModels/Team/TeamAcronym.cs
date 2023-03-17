// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamAcronym.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamAcronym
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.AggregateModels.Team
{
    using System.Collections.Generic;
    using TeamService.Domain.SeedWork;

    /// <summary>
    /// <see cref="EntityBase"/>
    /// </summary>
    /// <seealso cref="EntityBase"/>
    public class TeamAcronym : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamAcronym"/> class.
        /// </summary>
        /// <param name="acronym">The acronym.</param>
        internal TeamAcronym(string acronym)
            : this()
        {
            this.Acronym = acronym;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamAcronym"/> class.
        /// </summary>
        protected TeamAcronym()
        {
        }

        /// <summary>
        /// Gets the acronym.
        /// </summary>
        /// <value>The acronym.</value>
        public string Acronym { get; init; }

        /// <summary>
        /// Gets the atomic values.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.UUId;
        }
    }
}