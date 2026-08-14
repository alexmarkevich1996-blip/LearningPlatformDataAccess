using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    [PrimaryKey(nameof(CourseId), nameof(UserId))]
    [Table("courses_authors")]
    public class CourseAuthor
    {
        [Column("course_id")]
        public int CourseId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        public Course Course { get; set; }
        public User User { get; set; }
    }
}
