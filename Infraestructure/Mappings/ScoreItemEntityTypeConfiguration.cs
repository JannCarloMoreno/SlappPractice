using Domain.Entities.ProjectAggregate;
using Domain.Entities.ScoreAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Mappings
{
    public class ScoreItemEntityTypeConfiguration : IEntityTypeConfiguration<ScoreItem>
    {
        public void Configure(EntityTypeBuilder<ScoreItem> builder)
        {
            builder.ToTable("Scoreitem", "Management");

            builder.HasKey(si => si.Id)
                .HasName("FK_Management_Scoreitem_Id");

            builder.Property<int>(si => si.Id)
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .HasColumnName("Id");

            builder.Property<string>(si => si.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("Name");

            builder.Property<string>(si => si.Description)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("Description");

            builder.Property<DateTime>(si => si.CreatedAt)
                .IsRequired()
                .HasColumnName("Created_at");

            builder.Property<DateTime?>(si => si.UpdtatedAt)
                .IsRequired(false)
                .HasColumnName("Updated_at");

            builder.Property<bool>(si => si.Enabled)
                .IsRequired()
                .HasColumnName("Enabled");

            builder.HasMany<ScoreProject>(si => si.ScoreProjects).WithOne(sp => sp.ScoreItem).HasForeignKey(sp => sp.ScoreItemId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
