using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.User;

namespace ExampleProjectDDD.Domain.Factories.UserManagment
{
    public interface IRoleFactory
    {
        Role CreateRole(RoleName roleName, BaseId id);
    }
}
