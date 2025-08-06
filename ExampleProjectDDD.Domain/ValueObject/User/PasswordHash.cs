using ExampleProjectDDD.Domain.Exceptions.UserExceptions;

namespace ExampleProjectDDD.Domain.ValueObject.User
{
    public record PasswordHash
    {
        public string Value { get; }
        public PasswordHash(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new PasswordHashNullOrEmptyException();
            }
            if (value.Length > 35)
            {
                throw new PasswordHashIsTooLongException();
            }
            Value = value;
        }

        public static implicit operator string(PasswordHash passwordHash) => passwordHash.Value;
        public static implicit operator PasswordHash(string passwordHash) => new PasswordHash(passwordHash);
    }
}
