using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    public class Progress
    {
        public int UserId { get; set; }
        public int StepId { get; set; }
        public bool IsPassed { get; set; }
        public int Score { get; set; }

        public User User { get; set; }
        public Step Step { get; set; }
    }
}
