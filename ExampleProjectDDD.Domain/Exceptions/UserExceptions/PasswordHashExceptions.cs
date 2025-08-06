using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.UserExceptions
{
    internal class PasswordHashIsTooLongException : CourseManagementException
    {
        public PasswordHashIsTooLongException() : base("password is too long")
        {
        }
    }
    internal class PasswordHashNullOrEmptyException : CourseManagementException
    {
        public PasswordHashNullOrEmptyException() : base("password is emepty")
        {
        }
    }
}
