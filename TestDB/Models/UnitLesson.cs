using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    public class UnitLesson
    {
        public int UnitId { get; set; }
        public int LessonId { get; set; }

        public Unit Unit { get; set; }
        public Lesson Lesson { get; set; }
    }
}
