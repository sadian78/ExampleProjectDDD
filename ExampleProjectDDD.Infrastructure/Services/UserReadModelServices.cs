using ExampleProjectDDD.Application.Models.UserManagmenet;
using ExampleProjectDDD.Application.Sevices;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Services
{
    public class UserReadModelServices : IUserReadModelServices
    {
        private ReadDBContext _context;

        public UserReadModelServices(ReadDBContext context)
        {
            _context = context;
        }

        public async Task<UserReadModel> GetUserByIdAsync(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<UserReadModel>> GetUserListAsync(string username)
        {
            return await _context.Users.Where(u => u.UserName.Contains(username)).AsNoTracking().ToListAsync();
        }

        public async Task<bool> IsExistUserAsync(string username)
        {
            return await _context.Users.AnyAsync(u => u.UserName == username);
        }
    }
}
