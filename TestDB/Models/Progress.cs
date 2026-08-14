using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    [PrimaryKey(nameof(UserId), nameof(StepId))]
    [Table("progresses")]
    public class Progress
    {
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("step_id")]
        public int StepId { get; set; }

        [Column("is_passed")]
        public bool IsPassed { get; set; }

        [Column("score")]
        public int Score { get; set; }

        public User User { get; set; }
        public Step Step { get; set; }
    }
}
