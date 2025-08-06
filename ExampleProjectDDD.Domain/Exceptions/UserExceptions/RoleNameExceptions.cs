using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.UserExceptions
{
    internal class RoleNameNullOrEmptyException : CourseManagementException
    {
        public RoleNameNullOrEmptyException() : base("RoleName is emepty")
        {
        }
    }
    internal class RoleNameIsTooLongException : CourseManagementException
    {
        public RoleNameIsTooLongException() : base("RoleName is too long")
        {
        }
    }
}
