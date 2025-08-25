namespace ExampleProjectDDD.Infrastructure.Models.CourseManagment
{
    public class InstructorReadModel : BaseReadModel
    {
        public string Bio {  get; set; }
        public string Name {  get; set; }
        public double Rating {  get; set; }
        public double Exprience {  get; set; }
        public IReadOnlyList<CourseReadModel> Courses {  get; set; }
    }
}
