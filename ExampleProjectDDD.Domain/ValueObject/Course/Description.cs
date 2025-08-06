using ExampleProjectDDD.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectDDD.Domain.ValueObject.Course
{
    public record Description
    {
        public string Value { get;}
        public Description(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new DescriptionNullOrEmptyException();
            }
            if (value.Length>70)
            {
                throw new DescriptionLengthTooLowException();
            }
            Value = value;
        }
        public static implicit operator string(Description description) => description.Value;
        public static implicit operator Description(string description) => new Description(description);
    }
}
