using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment
{
    public interface ICourseCatalogFactory
    {
        CourseCatalog CreateCourseCatalog(BaseId id, Title title, Description description, BaseId courseId);
    }
}
