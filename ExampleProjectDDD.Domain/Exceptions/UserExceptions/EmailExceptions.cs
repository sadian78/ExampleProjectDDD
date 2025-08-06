using ExampleProjectDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectDDD.Domain.Exceptions.UserExceptions
{
    public class EmailNullOrEmptyException : CourseManagementException
    {
        public EmailNullOrEmptyException() : base("email is null")
        {

        }
    }
    public class EmailAddressIsNotCorrectException : CourseManagementException
    {
        public EmailAddressIsNotCorrectException() : base("email address is not correct")
        {

        }
    }
    public class EmailIsTooLongException : CourseManagementException
    {
        public EmailIsTooLongException() : base("email is too long")
        {

        }
    }
}
