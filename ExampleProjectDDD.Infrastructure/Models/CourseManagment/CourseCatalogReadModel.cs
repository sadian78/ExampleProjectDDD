namespace ExampleProjectDDD.Infrastructure.Models.CourseManagment
{
    public class CourseCatalogReadModel : BaseReadModel
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public Guid Course_Id { get; set; }
        public CourseReadModel Course { get; set; }
        public IReadOnlyList<LessonReadModel> Lessons { get; set; }

    }
}
