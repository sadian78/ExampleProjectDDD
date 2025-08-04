using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.UserExceptions
{
    internal class NameNullOrEmptyException : CourseManagementException
    {
        public NameNullOrEmptyException() : base("name is emepty")
        {
        }
    }
    internal class NameIsTooLongException : CourseManagementException
    {
        public NameIsTooLongException() : base("name is too long")
        {
        }
    }
}
