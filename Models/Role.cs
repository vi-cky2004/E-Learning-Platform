using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Platform.Models
{
        [Table("role")]
        public class Role
        {
            [Key]
            [Column("role_id")]
            public int RoleId { get; set; }

            [Column("role_name")]
            public string RoleName { get; set; } = string.Empty;
        }
 }

