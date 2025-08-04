namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class CourseCatalog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course {  get; set; }
        public int CourseID {  get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
