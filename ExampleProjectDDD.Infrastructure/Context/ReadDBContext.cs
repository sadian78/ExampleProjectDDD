using ExampleProjectDDD.Infrastructure.Models.CourseManagment;
using ExampleProjectDDD.Infrastructure.Models.PaymentManagment;
using ExampleProjectDDD.Infrastructure.Models.UserManagmenet;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Context
{
    internal sealed class ReadDBContext:DbContext
    {
        public ReadDBContext(DbContextOptions<ReadDBContext> options):base(options)
        {
            
        }

        #region Course
        public DbSet<CourseReadModel> Courses {  get; set; }
        public DbSet<CourseAttendeeReadModel> CourseAttendees {  get; set; }
        public DbSet<CourseCatalogReadModel> CourseCataloges {  get; set; }
        public DbSet<InstructorReadModel> Instructors {  get; set; }
        public DbSet<LessonReadModel> Lessons {  get; set; }
        #endregion

        #region Payment
        public DbSet<InvoiceReadModel> Invoices { get; set; }
        #endregion

        #region User
        public DbSet<RoleReadModel> Roles { get; set; }
        public DbSet<UserReadModel> Users { get; set; }
        public DbSet<UserRoleReadModel> UserRoles { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
