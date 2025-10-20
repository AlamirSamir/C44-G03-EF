namespace Assignment_03_EF.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Top_ID { get; set; }

        public Topic Topic { get; set; }

        public ICollection<Stud_Course> StudentsCourses { get; set; }

        public ICollection<Course_Inst> CourseInstructors { get; set; }
    }
}