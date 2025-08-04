using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions
{
    internal class TitleNullOrEmptyException : CourseManagementException
    {
        public TitleNullOrEmptyException() : base("title is empty")
        {

        }
    }
}
