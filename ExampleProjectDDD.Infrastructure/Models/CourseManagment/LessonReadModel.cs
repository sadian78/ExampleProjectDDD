namespace ExampleProjectDDD.Infrastructure.Models.CourseManagment
{
    public class LessonReadModel : BaseReadModel
    {
        public string Content {  get; set; }
        public string Title {  get; set; }
        public Guid CourseId { get; set; }
        public CourseReadModel Course { get; set; }
        public Guid CourseCatalogId {  get; set; }
        public CourseCatalogReadModel CourseCatalog { get; set; }
    }
}
