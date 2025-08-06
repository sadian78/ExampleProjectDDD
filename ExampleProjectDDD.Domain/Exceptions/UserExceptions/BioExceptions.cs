using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.UserExceptions
{
    internal class BioNullOrEmptyException : CourseManagementException
    {
        public BioNullOrEmptyException() : base("bio is emepty")
        {
        }
    }
    internal class BioIsTooLongException : CourseManagementException
    {
        public BioIsTooLongException() : base("Bio Is Too Long")
        {
        }
    }
}
