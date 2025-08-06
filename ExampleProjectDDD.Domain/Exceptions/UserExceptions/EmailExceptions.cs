using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.UserExceptions
{
    internal class EmailNullOrEmptyException : CourseManagementException
    {
        public EmailNullOrEmptyException() : base("email is null")
        {

        }
    }
    internal class EmailAddressIsNotCorrectException : CourseManagementException
    {
        public EmailAddressIsNotCorrectException() : base("email address is not correct")
        {

        }
    }
    internal class EmailIsTooLongException : CourseManagementException
    {
        public EmailIsTooLongException() : base("email is too long")
        {

        }
    }
}
