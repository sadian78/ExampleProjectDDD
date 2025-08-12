using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment
{
    public interface ICourseFactory
    {
        Course CreateCourse(BaseId id, Description description, Title title, Price price, BaseId instructor_ID);
    }
}
