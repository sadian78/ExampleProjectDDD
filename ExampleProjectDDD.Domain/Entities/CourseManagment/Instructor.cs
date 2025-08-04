namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public List<Course> Courses { get; set; }
    }
}
