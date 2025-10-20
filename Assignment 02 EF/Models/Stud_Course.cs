using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_02_EF.Models
{
    public class Stud_Course
    {
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }

        public int Grade { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}