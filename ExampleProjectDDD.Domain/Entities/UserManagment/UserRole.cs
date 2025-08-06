using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Entities.UserManagment
{
    public class UserRole : BaseEntity
    {
        public UserRole(BaseId id, BaseId userID, BaseId roleID) : base(id)
        {
            _userID = userID;
            _roleID = roleID;
        }

        public BaseId _userID { get; set; }
        public BaseId _roleID { get; set; }
    }
}
