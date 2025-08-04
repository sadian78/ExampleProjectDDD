using ExampleProjectDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectDDD.Domain.Exceptions
{
    internal class TitleLengthTooLongException:CourseManagementException
    {
        public TitleLengthTooLongException() : base("title's charechtors are too long")
        {

        }
    }
}
