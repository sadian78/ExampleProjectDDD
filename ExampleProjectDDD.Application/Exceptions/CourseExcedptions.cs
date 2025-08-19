using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Application.Exceptions
{
    public class CourseNotFoundExcedption : CourseManagementException
    {
        public CourseNotFoundExcedption() : base("Course Not Found")
        {
        }
    }
}
