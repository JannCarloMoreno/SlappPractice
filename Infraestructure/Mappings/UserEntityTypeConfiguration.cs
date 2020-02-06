using Domain.Entities.ProjectAggregate;
using Domain.Entities.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infraestructure.Mappings
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", "User");

            builder.HasKey(u => u.Id)
                .HasName("FK_User_Id");

            builder.Property<int>(u => u.Id)
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .HasColumnName("Id");

            builder.Property<string>(u => u.Name)
                .HasMaxLength(250)
                .IsRequired()
                .HasColumnName("Name");

            builder.Property<string>(u => u.Lastname)
                .HasMaxLength(250)
                .IsRequired()
                .HasColumnName("Lastname");

            builder.Property<string>(u => u.Username)
                .HasMaxLength(255)
                .IsRequired()
                .HasColumnName("Username");

            builder.Property<string>(u => u.Email)
                .HasMaxLength(250)
                .IsRequired()
                .HasColumnName("Email");

            builder.Property<DateTime>(u => u.Birthdate)
                .IsRequired()
                .HasColumnName("Birthdate");

            builder.Property<DateTime>(u => u.CreatedAt)
                .IsRequired()
                .HasColumnName("Created_at");

            builder.Property<DateTime?>(u => u.UpdtatedAt)
                .IsRequired(false)
                .HasColumnName("Updated_at");

            builder.Property(u => u.Enabled)
                .IsRequired()
                .HasDefaultValue(true)
                .HasColumnName("Enabled");

            builder.HasMany(u => u.UserProjects).WithOne(up => up.User).HasForeignKey(up => up.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
