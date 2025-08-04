using ExampleProjectDDD.Domain.Exceptions.UserExceptions;
using System.Xml.Linq;

namespace ExampleProjectDDD.Domain.ValueObject
{
    public record Name
    {
        public string Value { get; }
        public Name(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NameNullOrEmptyException();
            }
            if (value.Length > 35)
            {
                throw new NameIsTooLongException();
            }
            Value = value;
        }

        public static implicit operator string(Name name) => name.Value;
        public static implicit operator Name(string name) => new Name(name);
    }
}
