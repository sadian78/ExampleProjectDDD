using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment.Repository
{
    public class InstructorFactory : IInstructorFactory
    {
        public Instructor CreateInstructor(Name name, Bio bio, BaseId id)
        {
            return new Instructor(name, bio, id);
        }
    }
}
