using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_03_EF.Models
{
    [Table("Department_Data")]
    public class Department
    {
        [Key]
        [Column("Dept_ID")]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int? Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; }

        public Instructor Manager { get; set; }
    }
}
