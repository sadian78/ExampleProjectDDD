using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.Repositories.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Repositories.UserManagment
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private WriteDBContext _context;
        public UserRoleRepository(WriteDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(UserRole entity)
        {
            await _context.UserRoles.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(UserRole entity)
        {
            _context.UserRoles.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<UserRole>> GetAllAsync()
        {
            return await _context.UserRoles.ToListAsync();
        }

        public async Task<UserRole> GetAsync(BaseId Id)
        {
            return await _context.UserRoles.FindAsync(Id);
        }

        public async Task UpdateAsync(UserRole entity)
        {
            _context.UserRoles.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
