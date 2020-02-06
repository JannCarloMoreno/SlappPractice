using Domain.Entities.ProjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infraestructure.Mappings
{
    public class TechnologyProjectEntityTypeConfiguration : IEntityTypeConfiguration<TechnologyProject>
    {
        public void Configure(EntityTypeBuilder<TechnologyProject> builder)
        {
            builder.ToTable("TechnologyProject", "Management");

            builder.HasKey(tp => tp.Id)
                .HasName("PK_Management_TechnologyProject_Id");

            builder.Property<int>(tp => tp.Id)
                .UseIdentityColumn(1, 1)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property<DateTime>(tp => tp.CreatedAt)
                .IsRequired()
                .HasColumnName("Created_at");

            builder.Property<DateTime?>(tp => tp.UpdtatedAt)
                .IsRequired(false)
                .HasColumnName("Updated_at");
    }
}
