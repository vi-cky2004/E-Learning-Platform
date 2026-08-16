using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Platform.Models
{
    [Table("admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public int UserId { get; set; }

        public string? Designation { get; set; }

        public long? OfficePhone { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
