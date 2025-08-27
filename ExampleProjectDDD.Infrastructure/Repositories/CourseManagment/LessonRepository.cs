using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Repositories.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Repositories.CourseManagment
{
    public class LessonRepository : ILessonRepository
    {
        private WriteDBContext _context;
        public LessonRepository(WriteDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Lesson entity)
        {
            await _context.Lessons.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Lesson entity)
        {
            _context.Lessons.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Lesson>> GetAllAsync()
        {
            return await _context.Lessons.ToListAsync();
        }

        public async Task<Lesson> GetAsync(BaseId Id)
        {
            return await _context.Lessons.FindAsync(Id);
        }

        public async Task UpdateAsync(Lesson entity)
        {
            _context.Lessons.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
