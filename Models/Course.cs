using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Platform.Models
{
    [Table("course")]
    public class Course
    {
        [Key]
        [Column("course_id")]
        public int CourseId { get; set; }

        [Column("course_name")]
        public string CourseName { get; set; } = string.Empty;

        [Column("department_id")]
        public int DepartmentId { get; set; }

        [Column("teacher_id")]
        public int TeacherId { get; set; }

        [Column("description")]
        public string? Description { get; set; }
    }
}
