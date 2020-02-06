using Domain.Entities.ProjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infraestructure.Mappings
{
    public class ProjectEntityTypeConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects", "Management");

            builder.HasKey(p => p.Id)
                .HasName("PK_Management_Project_Id");

            builder.Property<int>(p => p.Id)
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .HasColumnName("Id");

            builder.Property<string>(p => p.Name)
                .HasMaxLength(255)
                .IsRequired()
                .HasColumnName("Name");

            builder.Property<string>(p => p.Description)
                .HasMaxLength(255)
                .IsRequired()
                .HasColumnName("Description");

            builder.Property<DateTime>(p => p.BeginDate)
                .IsRequired()
                .HasColumnName("Begin_date");

            builder.Property<DateTime?>(p => p.EndDate)
                .IsRequired(false)
                .HasColumnName("End_date");

            builder.Property<DateTime>(p => p.CreatedAt)
                .IsRequired()
                .HasColumnName("Created_at");

            builder.Property<DateTime?>(p => p.UpdtatedAt)
                .IsRequired(false)
                .HasColumnName("Updated_at");

            builder.Property<bool>(p => p.Enabled)
                .IsRequired()
                .HasColumnName("Enabled");

            builder.HasMany(p => p.UserProjects).WithOne(up => up.Project)
                .HasForeignKey(up => up.ProjectId).HasConstraintName("FK_")
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.TechnologiesProject).WithOne( tp => tp.Project).HasForeignKey(tp => tp.ProjectId).OnDelete(DeleteBehavior.Cascade)
        }
    }
}
