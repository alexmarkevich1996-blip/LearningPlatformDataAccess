using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_lesson
{
    [Table("software_update")]
    public class SoftwareUpdate
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("version")]
        public string Version { get; set; }
        [Column("release_date")]
        public DateTime ReleaseDate { get; set; }
        [Column("phone_id")]
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}