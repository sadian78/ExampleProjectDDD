using ExampleProjectDDD.Domain.Exceptions.UserExceptions;

namespace ExampleProjectDDD.Domain.ValueObject.User
{
    public record Email
    {
        public string Value { get; }
        public Email(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new EmailNullOrEmptyException();
            }
            var emailAddress=new System.Net.Mail.MailAddress(value);
            if (emailAddress.Address != value)
            {
                throw new EmailAddressIsNotCorrectException();
            }
            if (value.Length > 70)
            {
                throw new EmailIsTooLongException();
            }
            Value = value;
        }

        public static implicit operator string(Email email) => email.Value;
        public static implicit operator Email(string email) => new Email(email);
    }
}
