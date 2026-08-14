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
    [Table("course_reviews")]
    public class CourseReview
    {
        [Column("course_id")]
        public int CourseId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("comment_id")]
        public int? CommentId { get; set; }
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        [Column("text")]
        public string? Text { get; set; }
        [Column("score")]
        public int Score { get; set; }
        [Column("epic_count")]
        public int EpicCount { get; set; }
        [Column("abuse_count")]
        public int AbuseCount { get; set; }

        public Comment? Comment { get; set; }
        public Course Course { get; set; }
        public User User { get; set; }
    }
}
