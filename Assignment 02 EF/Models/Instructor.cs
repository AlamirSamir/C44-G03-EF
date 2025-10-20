namespace Assignment_02_EF.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public decimal HourRate { get; set; }
        public int? Dept_ID { get; set; }


        public Department Department { get; set; }
        public ICollection<Course_Inst> CourseInstructors { get; set; }

    }
}
