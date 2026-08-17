using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string? Title { get; set; }

        public Course Course { get; set; }
        public List<UnitLesson> UnitLessons { get; set; }
    }
}
