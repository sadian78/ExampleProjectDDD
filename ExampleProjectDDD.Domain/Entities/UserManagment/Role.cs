using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.User;

namespace ExampleProjectDDD.Domain.Entities.UserManagment
{
    public class Role: BaseEntity
    {

        public Role(RoleName roleName,BaseId id) : base(id)
        {
            _roleName = roleName;
        }

        public Role(BaseId id):base(id) {  }

        private RoleName _roleName;
        private LinkedList<UserRole> _userRoles;
    }
}
