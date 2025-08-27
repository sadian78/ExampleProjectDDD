using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Repositories.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Repositories.CourseManagment
{
    public class CourseCatalogRepository : ICourseCatalogRepository
    {
        private WriteDBContext _context;
        public CourseCatalogRepository(WriteDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(CourseCatalog entity)
        {
            await _context.CourseCataloges.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CourseCatalog entity)
        {
            _context.CourseCataloges.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<CourseCatalog>> GetAllAsync()
        {
            return await _context.CourseCataloges.ToListAsync();
        }

        public async Task<CourseCatalog> GetAsync(BaseId Id)
        {
            return await _context.CourseCataloges.FindAsync(Id);
        }

        public async Task UpdateAsync(CourseCatalog entity)
        {
            _context.CourseCataloges.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
