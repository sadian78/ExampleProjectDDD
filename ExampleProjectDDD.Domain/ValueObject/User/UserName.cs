using ExampleProjectDDD.Domain.Exceptions.UserExceptions;

namespace ExampleProjectDDD.Domain.ValueObject.User
{
    public record UserName
    {
        public string Value { get; }
        public UserName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new UserNameNullOrEmptyException();
            }
            if (value.Length > 35)
            {
                throw new UserNameIsTooLongException();
            }
            Value = value;
        }

        public static implicit operator string(UserName userName) => userName.Value;
        public static implicit operator UserName(string userName) => new UserName(userName);
    }
}
