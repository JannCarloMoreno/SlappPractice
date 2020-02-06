using Domain.Entities.ProjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infraestructure.Mappings
{
    public class StateProjectEntityTypeConfiguration : IEntityTypeConfiguration<StateProject>
    {
        public void Configure(EntityTypeBuilder<StateProject> builder)
        {
            builder.ToTable("StateProject");

            builder.HasKey(sp => sp.Id)
                .HasName("PK_Management_StateProject_Id");

            builder.Property<int>(sp => sp.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .HasColumnName("Id");

            builder.Property<DateTime>(sp => sp.CreatedAt)
                .IsRequired()
                .HasColumnName("Created_at");

            builder.Property<DateTime?>(sp => sp.UpdtatedAt)
                .IsRequired(false)
                .HasColumnName("Updated_at");

            builder.Property<int>(sp => sp.StateId)
                .IsRequired()
                .HasColumnName("StateId");

            builder.Property<bool>(sp => sp.Enabled)
                .IsRequired()
                .HasColumnName("Enabled");

            builder.Property<int>(sp => sp.ProjectId)
                .IsRequired()
                .HasColumnName("ProjectId");

            builder.Property<DateTime>(sp => sp.Date)
                .IsRequired()
                .HasColumnName("Date");

        }
    }
}