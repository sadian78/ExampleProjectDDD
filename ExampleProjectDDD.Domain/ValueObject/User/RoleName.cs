using ExampleProjectDDD.Domain.Exceptions.UserExceptions;

namespace ExampleProjectDDD.Domain.ValueObject.User
{
    public record RoleName
    {
        public string Value { get; }
        public RoleName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new RoleNameNullOrEmptyException();
            }
            if (value.Length > 35)
            {
                throw new RoleNameIsTooLongException();
            }
            Value = value;
        }

        public static implicit operator string(RoleName roleName) => roleName.Value;
        public static implicit operator RoleName(string roleName) => new RoleName(roleName);
    }
}
