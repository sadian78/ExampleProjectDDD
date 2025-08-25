using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Entities.UserManagment
{
    public class UserRole
    {
        public UserRole(BaseId userID, BaseId roleID)
        {
            _userID = userID;
            _roleID = roleID;
        }
        public UserRole() { }
        public BaseId _userID { get; set; }
        public BaseId _roleID { get; set; }
    }
}
