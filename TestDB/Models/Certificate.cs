using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    public class Certificate
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public DateTime IssueDate { get; set; }
        public int Grade { get; set;  }
        public string Url { get; set; }
        public string Title { get; set; }

        public Course Course { get; set; }
        public User User { get; set; }
    }
}
