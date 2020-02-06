using Domain.Entities.ProjectAggregate;
using Domain.Entities.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infraestructure.Mappings
{
    public class ScoreProjectEntityTypeConfiguration : IEntityTypeConfiguration<ScoreProject>
    {
        public void Configure(EntityTypeBuilder<ScoreProject> builder)
        {
            builder.ToTable("ScoreProjects", "Management");

            builder.HasKey(sp => sp.Id)
                .HasName("FK_Management_ScoreProjects_Id");

            builder.Property<int>(sp => sp.Id)
                .UseIdentityColumn(1, 1)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property<int>(sp => sp.Score)
                .IsRequired()
                .HasColumnName("Score");

            builder.Property<int>(sp => sp.ScoreItemId)
                .IsRequired()
                .HasColumnName("ScoreItem_Id");

            builder.Property<int>(sp => sp.UserEvaluatedId)
                .IsRequired()
                .HasColumnName("User_evaluated_Id");

            builder.Property<int>(sp => sp.UserEvaluatorId)
                .IsRequired()
                .HasColumnName("User_evaluator_Id");

            builder.Property<DateTime>(sp => sp.CreatedAt)
                .IsRequired()
                .HasColumnName("Created_at");

            builder.Property<DateTime?>(sp => sp.UpdtatedAt)
                .IsRequired(false)
                .HasColumnName("Updated_at");

        }
    }
}
