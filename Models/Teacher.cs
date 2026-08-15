using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Platform.Models
{

    [Table("teacher")]
    public class Teacher
    {
        [Key]
        [Column("teacher_id")]
        public int TeacherId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("department_id")]
        public int DepartmentId { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }
    }
}
