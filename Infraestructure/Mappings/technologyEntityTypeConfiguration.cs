using Domain.Entities.ProjectAggregate;
using Domain.Entities.TechnologyAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infraestructure.Mappings
{
    public class technologyEntityTypeConfiguration : IEntityTypeConfiguration<Technology>
    {
        public void Configure(EntityTypeBuilder<Technology> builder)
        {
            builder.ToTable("Technology", "Management");

            builder.HasKey(t => t.Id)
                .HasName("PK_Management_Technology_Id");

            builder.Property<int>(t => t.Id)
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .HasColumnName("Id");

            builder.Property<string>(t => t.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("Name");

            builder.Property<string>(t => t.Description)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("Description");

            builder.Property<DateTime>(t => t.CreatedAt)
                .IsRequired()
                .HasColumnName("Created_at");

            builder.Property<DateTime?>(t => t.UpdtatedAt)
                .IsRequired(false)
                .HasColumnName("Updated_at");

            builder.Property<bool>(t => t.Enabled)
                .IsRequired()
                .HasColumnName("Enabled");

            builder.HasMany<TechnologyProject>(t => t.TechnologyProjects).WithOne(tp => tp.Technology).HasForeignKey(tp => tp.TechnologyId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
