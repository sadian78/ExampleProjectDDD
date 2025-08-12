using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment
{
    public interface IInstructorFactory
    {
        Instructor CreateInstructor(Name name, Bio bio, BaseId id);
    }
}
