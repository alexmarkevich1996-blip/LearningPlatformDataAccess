using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using stepik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Data.Configurations
{
    public class StepConfiguration : IEntityTypeConfiguration<Step>
    {
        public void Configure(EntityTypeBuilder<Step> builder)
        {
            builder.ToTable("steps");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasColumnName("id");

            builder.Property(s => s.LessonId)
                .HasColumnName("lesson_id");

            builder.Property(s => s.Position)
                .HasColumnName("position");

            builder.Property(s => s.Title)
                .HasColumnName("title");

            builder.Property(s => s.Content)
                .HasColumnName("content");

            builder.Property(s => s.Cost)
                .HasColumnName("cost");

            builder.HasOne(s => s.Lesson)
                .WithMany(l => l.Steps)
                .HasForeignKey(s => s.LessonId);
        }
    }
}
