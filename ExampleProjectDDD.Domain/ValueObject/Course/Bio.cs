using ExampleProjectDDD.Domain.Exceptions.UserExceptions;

namespace ExampleProjectDDD.Domain.ValueObject.Course
{
    public record Bio
    {
        public string Value { get; }
        public Bio(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new BioNullOrEmptyException();
            }
            if (value.Length > 200)
            {
                throw new BioIsTooLongException();
            }
            Value = value;
        }

        public static implicit operator string(Bio bio) => bio.Value;
        public static implicit operator Bio(string bio) => new Bio(bio);
    }
}
