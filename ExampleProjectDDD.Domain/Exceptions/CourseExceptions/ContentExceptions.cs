using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.CourseExceptions
{
    public class ContentNullOrEmptyException : CourseManagementException
    {
        public ContentNullOrEmptyException() : base("content is null")
        {

        }
    }
}
