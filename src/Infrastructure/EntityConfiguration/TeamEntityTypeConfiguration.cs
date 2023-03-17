// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Infrastructure.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamService.Domain.AggregateModels.Team;

    internal class TeamEntityTypeConfiguration : EntityTypeConfiguration<Team>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "Team";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Team> builder)
        {
            builder.Property(f => f.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(f => f.ShortName)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(f => f.Acronyms);
        }
    }
}