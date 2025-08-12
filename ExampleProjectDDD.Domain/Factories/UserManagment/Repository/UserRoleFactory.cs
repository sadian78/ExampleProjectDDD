using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Factories.UserManagment.Repository
{
    public class UserRoleFactory : IUserRoleFactory
    {
        public UserRole CreateUserRoleUserRole(BaseId id, BaseId userID, BaseId roleID)
        {
            return new UserRole(id, userID, roleID);
        }
    }
}
