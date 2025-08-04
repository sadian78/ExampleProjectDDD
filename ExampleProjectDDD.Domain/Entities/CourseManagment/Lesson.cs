namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class Lesson
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CourseCatalogID {  get; set; }
    }
}
