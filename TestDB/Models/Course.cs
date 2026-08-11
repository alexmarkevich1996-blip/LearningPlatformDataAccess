using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    [Table("courses")]
    public class Course
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Column("summary")]
        public string? Summary { get; set; }
        [Column("photo")]
        public string? Photo { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        public CertificateSetting CertificateSetting { get; set; }
    }
}
