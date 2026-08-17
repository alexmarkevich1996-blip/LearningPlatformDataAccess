using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    public class CourseReview
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public int? CommentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Text { get; set; }
        public int Score { get; set; }
        public int EpicCount { get; set; }
        public int AbuseCount { get; set; }

        public Comment? Comment { get; set; }
        public Course Course { get; set; }
        public User User { get; set; }
    }
}
