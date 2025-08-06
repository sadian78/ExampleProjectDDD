using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.CourseExceptions
{
    internal class DescriptionNullOrEmptyException : CourseManagementException
    {
        public DescriptionNullOrEmptyException() : base("description is null")
        {

        }
    }
    internal class DescriptionLengthTooLowException : CourseManagementException
    {
        public DescriptionLengthTooLowException() : base("description's charechtors are too long")
        {

        }
    }
}
