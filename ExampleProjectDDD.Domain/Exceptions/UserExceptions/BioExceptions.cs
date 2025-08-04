using ExampleProjectDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
