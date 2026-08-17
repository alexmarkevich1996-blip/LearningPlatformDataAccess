using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public string? Details { get; set; }
        public DateTime JoinDate { get; set; }
        public string? Avatar { get; set; }
        public bool IsActive { get; set; } = true;
        public int Knowledge { get; set; }
        public int Reputation { get; set; }
        public int FollowersCount { get; set; }
        public int DaysWithoutBreak { get; set; }
        public int DaysWithoutBreakMax { get; set; }
        public int SolvedTasks { get; set; }

        public List<UserCourse> UserCourses { get; set; }
        public List<CourseAuthor> CourseAuthors { get; set; }
        public List<Certificate> Certificates { get; set; }
        public List<UserSocialProvider> UserSocialProviders { get; set; }
        public List<Progress> Progresses { get; set; }
        public List<Comment> Comments { get; set; }
        public List<CourseReview> CourseReviews { get; set; }
    }
}
