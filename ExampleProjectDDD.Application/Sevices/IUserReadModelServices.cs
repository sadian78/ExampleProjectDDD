using ExampleProjectDDD.Application.Models.UserManagmenet;

namespace ExampleProjectDDD.Application.Sevices
{
    public interface IUserReadModelServices
    {
        Task<bool> IsExistUserAsync(string username);
        Task<UserReadModel> GetUserByIdAsync(Guid id);
        Task<IEnumerable<UserReadModel>> GetUserListAsync(string username);
    }
}
