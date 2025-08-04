using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.CourseExceptions
{
    internal class TitleLengthTooLongException : CourseManagementException
    {
        public TitleLengthTooLongException() : base("title's charechtors are too long")
        {

        }
    }
    internal class TitleLengthTooLowException : CourseManagementException
    {
        public TitleLengthTooLowException() : base("title's charechtors are too low")
        {

        }
    }
    internal class TitleNullOrEmptyException : CourseManagementException
    {
        public TitleNullOrEmptyException() : base("title is empty")
        {

        }
    }
}
