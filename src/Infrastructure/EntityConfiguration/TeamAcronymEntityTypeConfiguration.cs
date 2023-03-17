// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamAcronymEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamAcronymEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Infrastructure.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamService.Domain.AggregateModels.Team;

    internal class TeamAcronymEntityTypeConfiguration : EntityTypeConfiguration<TeamAcronym>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "TeamAcronym";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<TeamAcronym> builder)
        {
            builder.Property(f => f.Acronym)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}