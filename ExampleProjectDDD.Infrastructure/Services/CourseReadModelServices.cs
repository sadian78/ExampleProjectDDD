using ExampleProjectDDD.Application.Models.CourseManagment;
using ExampleProjectDDD.Application.Sevices;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Services
{
    public class CourseReadModelServices : ICourseReadModelServices
    {
        private ReadDBContext _context;

        public CourseReadModelServices(ReadDBContext context)
        {
            _context = context;
        }

        public async Task<CourseReadModel> GetCourseByIdAsync(Guid id)
        {
            return await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<CourseReadModel>> GetCoursesAsync()
        {
           return await _context.Courses.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<CourseReadModel>> GetCoursesByPhraseAsync(string phrase)
        {
            return await _context.Courses.Where(c=>c.Title.Contains(phrase)).AsNoTracking().ToListAsync();
        }

        public async Task<bool> IsExistCourseAsync(string courseName)
        {
            return await _context.Courses.AnyAsync(c => c.Title == courseName);
        }
    }
}
