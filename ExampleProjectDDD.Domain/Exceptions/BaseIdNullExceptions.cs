using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions
{
    internal class BaseIdNullExceptions : CourseManagementException
    {
        public BaseIdNullExceptions() : base("id is emepty")
        {
        }
    }
}
