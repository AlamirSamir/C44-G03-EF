namespace Assignment_03_EF.Models
{
    public class Topic
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
