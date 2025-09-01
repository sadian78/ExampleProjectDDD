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
        public async Task<bool> IsExistCourseAsync(string courseName)
        {
            return await _context.Courses.AnyAsync(c => c.Title == courseName);
        }
    }
}
