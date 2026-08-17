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
    public class UnitLessonConfiguration : IEntityTypeConfiguration<UnitLesson>
    {
        public void Configure(EntityTypeBuilder<UnitLesson> builder)
        {
            builder.ToTable("unit_lessons");

            builder.HasKey(ul => new { ul.UnitId, ul.LessonId });

            builder.Property(ul => ul.UnitId)
                .HasColumnName("unit_id");

            builder.Property(ul => ul.LessonId)
                .HasColumnName("lesson_id");

            builder.HasOne(ul => ul.Unit)
                .WithMany(u => u.UnitLessons)
                .HasForeignKey(ul => ul.UnitId);

            builder.HasOne(ul => ul.Lesson)
                .WithMany(l => l.UnitLessons)
                .HasForeignKey(ul => ul.LessonId);
        }
    }
}
