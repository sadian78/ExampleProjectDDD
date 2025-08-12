using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.User;

namespace ExampleProjectDDD.Domain.Factories.UserManagment
{
    public interface IUserFactory
    {
        User CreateUser(UserName userName, PasswordHash passwordHash, Email email, BaseId id);
    }
}
