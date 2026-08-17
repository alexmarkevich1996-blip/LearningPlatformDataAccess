using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    public class UserCourse
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsPinned { get; set; }
        public bool IsArchived { get; set; }
        public DateTime LastViewed { get; set; }

        public User User { get; set; }
        public Course Course { get; set; }
    }
}
