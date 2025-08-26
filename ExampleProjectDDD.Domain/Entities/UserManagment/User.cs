using ExampleProjectDDD.Domain.Entities.CourseManagment;
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

        private UserName _userName;
        private PasswordHash _passwordHash;
        private Email _email;
        private bool IsConfirmed;
        private LinkedList<UserRole> _userRoles;
        private LinkedList<CourseAttendee> _courseAttendees;
    }
}
