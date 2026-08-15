using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Platform.Models
{
        [Table("users")]
        public class User
        {
            [Key]
            [Column("user_id")]
            public int UserId { get; set; }

            [Column("name")]
            [Required]
            [MaxLength(100)]
            public string Name { get; set; } = string.Empty;

            [Column("email")]
            [Required]
            [EmailAddress]
            [MaxLength(150)]
            public string Email { get; set; } = string.Empty;

            [Column("password")]
            [Required]
            public string Password { get; set; } = string.Empty;

            [Column("phone")]
            [MaxLength(15)]
            public string? Phone { get; set; }

            [Column("role")]
            public int Role { get; set; }

            [Column("created_at")]
            public DateTime? CreatedAt { get; set; }

            [Column("updated_at")]
            public DateTime? UpdatedAt { get; set; }
        }
}
