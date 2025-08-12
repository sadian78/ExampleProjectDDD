using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Factories.UserManagment
{
    public interface IUserRoleFactory
    {
        UserRole CreateUserRoleUserRole(BaseId id, BaseId userID, BaseId roleID);
    }
}
