using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.UserExceptions
{
    internal class UserNameNullOrEmptyException : CourseManagementException
    {
        public UserNameNullOrEmptyException() : base("userName is emepty")
        {
        }
    }

    internal class UserNameIsTooLongException : CourseManagementException
    {
        public UserNameIsTooLongException() : base("userName is too long")
        {
        }
    }
}
