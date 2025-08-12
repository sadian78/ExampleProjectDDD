using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.User;

namespace ExampleProjectDDD.Domain.Factories.UserManagment.Repository
{
    public class RoleFactory : IRoleFactory
    {
        public Role CreateRole(RoleName roleName, BaseId id)
        {
           return new Role(roleName, id);
        }
    }
}
