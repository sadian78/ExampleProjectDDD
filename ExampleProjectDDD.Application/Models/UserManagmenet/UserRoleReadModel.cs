namespace ExampleProjectDDD.Application.Models.UserManagmenet
{
    public class UserRoleReadModel 
    {
        public Guid UserID { get; set; }
        public UserReadModel User { get; set; }
        public Guid RoleID { get; set; }
        public RoleReadModel Role { get; set; }
    }
}
