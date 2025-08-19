using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Application.Exceptions
{
    public class UserNotFoundException : CourseManagementException
    {
        public UserNotFoundException() : base("User Not Found")
        {
        }
    }
}
