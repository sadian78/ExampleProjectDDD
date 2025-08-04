
namespace ExampleProjectDDD.Domain.Entities.UserManagment
{
    public class UserRole
    {
        public User User { get; set; }
        public Guid UserID { get; set; }
        public Role Role { get; set; }
        public int RoleID { get; set; }
    }
}
