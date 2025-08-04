
namespace ExampleProjectDDD.Domain.Entities.UserManagment
{
    public class User
    {
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
