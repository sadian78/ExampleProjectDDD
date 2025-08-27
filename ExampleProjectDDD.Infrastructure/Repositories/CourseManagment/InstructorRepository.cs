using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Repositories.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Repositories.CourseManagment
{
    public class InstructorRepository : IInstructorRepository
    {
        private WriteDBContext _context;
        public InstructorRepository(WriteDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Instructor entity)
        {
            await _context.Instructors.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Instructor entity)
        {
            _context.Instructors.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Instructor>> GetAllAsync()
        {
            return await _context.Instructors.ToListAsync();
        }

        public async Task<Instructor> GetAsync(BaseId Id)
        {
            return await _context.Instructors.FindAsync(Id);
        }

        public async Task UpdateAsync(Instructor entity)
        {
            _context.Instructors.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
