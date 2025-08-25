namespace ExampleProjectDDD.Infrastructure.Models.UserManagmenet
{
    public class RoleReadModel : BaseReadModel
    {
        public string RoleName { get; set; }
        public IReadOnlyList<UserRoleReadModel> UserRoles { get; set; }
    }
}
