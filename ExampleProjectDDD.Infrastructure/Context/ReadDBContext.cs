using ExampleProjectDDD.Infrastructure.Configes.ConfigReadModels;
using ExampleProjectDDD.Application.Models.CourseManagment;
using ExampleProjectDDD.Application.Models.PaymentManagment;
using ExampleProjectDDD.Application.Models.UserManagmenet;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Context
{
    public sealed class ReadDBContext:DbContext
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
            var configuration = new ConfigurationReadModel();

            #region Course mannagment configuration
            modelBuilder.ApplyConfiguration<CourseAttendeeReadModel>(configuration);
            modelBuilder.ApplyConfiguration<LessonReadModel>(configuration);
            modelBuilder.ApplyConfiguration<InstructorReadModel>(configuration);
            modelBuilder.ApplyConfiguration<CourseReadModel>(configuration);
            modelBuilder.ApplyConfiguration<CourseCatalogReadModel>(configuration);
            #endregion

            #region Payment manegmant configration
            modelBuilder.ApplyConfiguration<InvoiceReadModel>(configuration);
            #endregion

            #region User managment configuration
            modelBuilder.ApplyConfiguration<UserReadModel>(configuration);
            modelBuilder.ApplyConfiguration<RoleReadModel>(configuration);
            modelBuilder.ApplyConfiguration<UserReadModel>(configuration);
            #endregion
        }
    }
}
