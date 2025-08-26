using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Entities.PaymentManagment;
using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Infrastructure.Configes.ConfigWriteModels;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Context
{
    internal sealed class WriteDBContext : DbContext
    {
        public WriteDBContext(DbContextOptions<WriteDBContext> options) : base(options)
        {

        }
        #region Course
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseAttendee> CourseAttendees { get; set; }
        public DbSet<CourseCatalog> CourseCataloges { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        #endregion

        #region Payment
        public DbSet<Invoice> Invoices { get; set; }
        #endregion

        #region User
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configuration = new ConfigurationWriteModel();

            #region Course mannagment configuration
            modelBuilder.ApplyConfiguration<CourseAttendee>(configuration);
            modelBuilder.ApplyConfiguration<Lesson>(configuration);
            modelBuilder.ApplyConfiguration<Instructor>(configuration);
            modelBuilder.ApplyConfiguration<Course>(configuration);
            modelBuilder.ApplyConfiguration<CourseCatalog>(configuration);
            #endregion

            #region Payment manegmant configration
            modelBuilder.ApplyConfiguration<Invoice>(configuration);
            #endregion

            #region User managment configuration
            modelBuilder.ApplyConfiguration<UserRole>(configuration);
            modelBuilder.ApplyConfiguration<Role>(configuration);
            modelBuilder.ApplyConfiguration<User>(configuration);
            #endregion
        }
    }
}
