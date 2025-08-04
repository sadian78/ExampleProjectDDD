using ExampleProjectDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectDDD.Domain.Exceptions
{
    internal class TitleLengthTooLowException : CourseManagementException
    {
        public TitleLengthTooLowException() : base("title's charechtors are too low")
        {

        }
    }
}
}
