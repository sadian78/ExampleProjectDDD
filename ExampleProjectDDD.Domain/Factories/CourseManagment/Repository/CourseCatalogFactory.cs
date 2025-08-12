using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment.Repository
{
    public class CourseCatalogFactory : ICourseCatalogFactory
    {
        public CourseCatalog CreateCourseCatalog(BaseId id, Title title, Description description, BaseId courseId)
        {
            return new CourseCatalog(id, title, description, courseId);
        }
    }
}
