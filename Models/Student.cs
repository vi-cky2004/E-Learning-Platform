using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Platform.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        [Column("student_id")]
        public int StudentId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("department_id")]
        public int DepartmentId { get; set; }

        [Column("roll_no")]
        public string RollNo { get; set; } = string.Empty;
    }
}
