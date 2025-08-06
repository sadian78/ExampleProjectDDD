using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.User;
using ExampleProjectDDD.Shared.Abstraction.Domain;

namespace ExampleProjectDDD.Domain.Entities.UserManagment
{
    public class User : AggregateRoot<BaseId>
    {
        public User(UserName userName, PasswordHash passwordHash, Email email, BaseId id)
        {
            ID = id;
            _userName = userName;
            _passwordHash = passwordHash;
            _email = email;
        }
        public User() { }

        private UserName _userName { get; set; }
        public PasswordHash _passwordHash { get; set; }
        public Email _email { get; set; }
        public bool IsConfirmed { get; set; }
        private LinkedList<UserRole> _userRoles { get; set; }
    }
}
