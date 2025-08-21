namespace ExampleProjectDDD.Application.DTOs.UserManagment
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
    }
    public class UsersListDTO
    {
        public IEnumerable<UserDTO> Users { get; set; }
    }
}
