using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Platform.Models
{
    [Table("student")]
    public class Student
    {

        public int StudentId { get; set; }

        public int UserId { get; set; }

        public int DepartmentId { get; set; }

        public string RollNo { get; set; } = string.Empty;

        public string? Gender { get; set; }

        public string? Address { get; set; }

        public DateOnly? Dob { get; set; }

        public bool IsActive { get; set; }
    }
}

