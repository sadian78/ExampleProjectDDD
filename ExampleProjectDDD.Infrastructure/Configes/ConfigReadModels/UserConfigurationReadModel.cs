using ExampleProjectDDD.Application.Models.UserManagmenet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExampleProjectDDD.Infrastructure.Configes.ConfigReadModels
{
    internal sealed partial class ConfigurationReadModel : IEntityTypeConfiguration<UserReadModel>,
        IEntityTypeConfiguration<RoleReadModel>, IEntityTypeConfiguration<UserRoleReadModel>
    {
        public void Configure(EntityTypeBuilder<UserReadModel> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.IsConfirmed);
            //relation many to many but UserRole class is mid class and many in User table
            builder.HasMany(u => u.UserRoles)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserID);
            //relation one to many but many in User table
            builder.HasMany(u => u.Invoices)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserID);
            //relation one to many but many in User table
            builder.HasMany(u => u.CourseAttendees)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserID);
        }

        public void Configure(EntityTypeBuilder<RoleReadModel> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.RoleName).IsRequired();
            //relation one to many but many in User table
            builder.HasMany(u => u.UserRoles)
                .WithOne(r => r.Role)
                .HasForeignKey(r => r.RoleID);
        }

        public void Configure(EntityTypeBuilder<UserRoleReadModel> builder)
        {
            builder.ToTable("UserRoles");
            builder.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(r => r.RoleID);
            builder.HasOne(ur => ur.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(r => r.UserID);
        }
    }
}
