// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstantObject.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ConstantObject
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.Utils
{
    /// <summary>
    /// <see cref="ConstantObject"/>
    /// </summary>
    public abstract class ConstantObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantObject"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        protected ConstantObject(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; init; }
    }
}