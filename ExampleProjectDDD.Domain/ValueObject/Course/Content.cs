using ExampleProjectDDD.Domain.Exceptions.CourseExceptions;

namespace ExampleProjectDDD.Domain.ValueObject.Course
{
    public record Content
    {
        public string Value { get; }
        public Content(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ContentNullOrEmptyException();
            }
            Value = value;
        }

        public static implicit operator string(Content content) => content.Value;
        public static implicit operator Content(string content) => new Content(content);
    }
}
