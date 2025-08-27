using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.Repositories.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Repositories.UserManagment
{
    public class RoleRepository : IRoleRepository
    {
        private WriteDBContext _context;
        public RoleRepository(WriteDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Role entity)
        {
            await _context.Roles.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Role entity)
        {
            _context.Roles.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Role>> GetAllAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role> GetAsync(BaseId Id)
        {
            return await _context.Roles.FindAsync(Id);
        }

        public async Task UpdateAsync(Role entity)
        {
            _context.Roles.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
