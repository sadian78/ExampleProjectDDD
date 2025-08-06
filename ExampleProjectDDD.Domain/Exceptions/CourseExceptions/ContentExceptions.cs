using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.CourseExceptions
{
    internal class ContentNullOrEmptyException : CourseManagementException
    {
        public ContentNullOrEmptyException() : base("content is null")
        {

        }
    }
}
