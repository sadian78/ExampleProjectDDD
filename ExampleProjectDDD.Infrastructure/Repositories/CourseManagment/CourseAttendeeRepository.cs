using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Repositories.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Repositories.CourseManagment
{
    public class CourseAttendeeRepository : ICourseAttendeeRepository
    {
        private WriteDBContext _context;
        public CourseAttendeeRepository(WriteDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(CourseAttendee entity)
        {
            await _context.CourseAttendees.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CourseAttendee entity)
        {
            _context.CourseAttendees.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<CourseAttendee>> GetAllAsync()
        {
            return await _context.CourseAttendees.ToListAsync();
        }

        public async Task<CourseAttendee> GetAsync(BaseId Id)
        {
            return await _context.CourseAttendees.FindAsync(Id);
        }

        public async Task UpdateAsync(CourseAttendee entity)
        {
            _context.CourseAttendees.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
