using Domain.Entities.ProjectAggregate;
using Domain.Entities.StateAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infraestructure.Mappings
{
    public class StateEntityTypeConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("State", "Management");

            builder.HasKey(s => s.Id)
                .HasName("PK_Management_Id");

            builder.Property<int>(s => s.Id)
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .HasColumnName("Id");

            builder.Property<string>(s => s.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("Name");

            builder.Property<string>(s => s.Description)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("Description");

            builder.Property<DateTime>(s => s.CreatedAt)
                .IsRequired()
                .HasColumnName("Created_at");

            builder.Property<DateTime?>(s => s.UpdtatedAt)
                .IsRequired(false)
                .HasColumnName("Created_at");

            builder.Property<bool>(s => s.Enabled)
                .IsRequired()
                .HasColumnName("Enabled");

            builder.HasMany<StateProject>(s => s.StateProjects).WithOne(sp => sp.State).HasForeignKey(sp => sp.StateId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
