using ExampleProjectDDD.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectDDD.Domain.ValueObject
{
    public record Title
    {
        public string Value { get;  }
        public Title(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new TitleNullOrEmptyException();
            }
            if (value.Length > 30)
            {
                throw new TitleLengthTooLongException();
            }
            if (value.Length < 3)
            {
                throw new TitleLengthTooLowException();
            }

            Value = value;
        }

        public static implicit operator string(Title title) => title.Value;
        public static implicit operator Title(string title) => new Title(title);
    }
}
