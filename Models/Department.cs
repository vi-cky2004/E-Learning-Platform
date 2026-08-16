using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Platform.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        [Column("dept_id")]
        public int DepartmentId { get; set; }

        [Column("dept_name")]
        public string DepartmentName { get; set; } = string.Empty;
    }
}
