using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_lesson
{
    public class Guarantee
    {
        [Key, ForeignKey(nameof(Phone))]
        public int PhoneId { get; set; }
        public int Months { get; set; }
    }
}
