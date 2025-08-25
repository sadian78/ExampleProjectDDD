using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Factories.UserManagment.Repository
{
    public class UserRoleFactory : IUserRoleFactory
    {
        public UserRole CreateUserRoleUserRole( BaseId userID, BaseId roleID)
        {
            return new UserRole( userID, roleID);
        }
    }
}
