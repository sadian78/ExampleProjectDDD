using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Entities.PaymentManagment;
using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Infrastructure.Configes.ConfigWriteModels;
using ExampleProjectDDD.Shared.Abstraction.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ExampleProjectDDD.Infrastructure.Context
{
    public sealed class WriteDBContext : DbContext
    {
        private readonly IDomainEventDispatcher _dispatcher;
        public WriteDBContext(DbContextOptions<WriteDBContext> options, IDomainEventDispatcher dispatcher) : base(options)
        {
            _dispatcher = dispatcher;
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


        #region Dispatch Domein Event
        public override int SaveChanges()
        {
            var response = base.SaveChanges();
            DispatcherDomainEvent().GetAwaiter().GetResult();
            return response;
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var response = await base.SaveChangesAsync(cancellationToken);
            await DispatcherDomainEvent();
            return response;
        }

        private async Task DispatcherDomainEvent()
        {
            var aggregateRoots = ChangeTracker.Entries<AggregateRoot<BaseId>>()
                .Select(entry => entry.Entity)
                .Where(aggregate => aggregate.Events.Any())
                .ToArray();

            foreach (var aggregateRoot in aggregateRoots)
            {
                var events = aggregateRoot.Events.ToArray();
                aggregateRoot.ClearEvents();

                foreach (var @event in events)
                {
                    await _dispatcher.DispatchAsync(@event);
                }
            }
        }
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
