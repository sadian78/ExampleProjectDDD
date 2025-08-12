using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.User;

namespace ExampleProjectDDD.Domain.Factories.UserManagment.Repository
{
    public class UserFactory : IUserFactory
    {
        public User CreateUser(UserName userName, PasswordHash passwordHash, Email email, BaseId id)
        {
            return new User(userName, passwordHash, email, id);
        }
    }
}
