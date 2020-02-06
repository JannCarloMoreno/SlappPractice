using Domain.Entities.ProjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Infraestructure.Mappings
{
    public class UserProjectEntityTypeConfiguration : IEntityTypeConfiguration<UserProject>
    {
        public void Configure(EntityTypeBuilder<UserProject> builder)
        {
            builder.ToTable("UserProjects", "Management");

            builder.HasKey(up => up.Id)
                .HasName("FK_Management_UserProject_Id");

            builder.Property<int>(up => up.Id)
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .HasColumnName("Id");

            builder.Property<int>(up => up.UserId)
                .IsRequired()
                .HasColumnName("User_Id");

            builder.Property<int>(up => up.ProjectId)
                .IsRequired()
                .HasColumnName("Project_Id");

            builder.Property<DateTime>(up => up.StartDate)
                .IsRequired()
                .HasColumnName("Start_date");

            builder.Property<DateTime?>(up => up.EndDate)
                .IsRequired(false)
                .HasColumnName("End_date");

            builder.Property<bool>(up => up.Enabled)
                .IsRequired()
                .HasColumnName("Enabled");
        }
    }
}
