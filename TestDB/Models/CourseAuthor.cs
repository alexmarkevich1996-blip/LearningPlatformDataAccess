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
    public class CourseAuthor
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }

        public Course Course { get; set; }
        public User User { get; set; }
    }
}
