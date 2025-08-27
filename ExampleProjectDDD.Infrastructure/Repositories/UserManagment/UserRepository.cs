using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.Repositories.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Repositories.UserManagment
{
    public class UserRepository : IUserRepository
    {
        private WriteDBContext _context;
        public UserRepository(WriteDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User entity)
        {
            _context.Users.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetAsync(BaseId Id)
        {
            return await _context.Users.FindAsync(Id);
        }

        public async Task UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
