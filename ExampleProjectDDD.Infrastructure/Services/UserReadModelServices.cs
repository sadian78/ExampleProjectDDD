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

        public async Task<bool> IsExistUserAsync(string username)
        {
            return await _context.Users.AnyAsync(u => u.UserName == username);
        }
    }
}
