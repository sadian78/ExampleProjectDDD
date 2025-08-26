using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExampleProjectDDD.Infrastructure.Configes.ConfigWriteModels
{
    internal sealed partial class ConfigurationWriteModel : IEntityTypeConfiguration<User>, IEntityTypeConfiguration<Role>
        , IEntityTypeConfiguration<UserRole>
    {
        private ValueConverter usernameConvertor = new ValueConverter<UserName, string>(userName => userName.Value, userName => new UserName(userName));
        private ValueConverter passwordHashConvertor = new ValueConverter<PasswordHash, string>(passwordHash => passwordHash.Value, passwordHash => new PasswordHash(passwordHash));
        private ValueConverter emailConvertor = new ValueConverter<Email, string>(email => email.Value, email => new Email(email));
        private ValueConverter roleNameConvertor = new ValueConverter<RoleName, string>(roleName => roleName.Value, roleName => new RoleName(roleName));

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.ID);
            builder.Property(u => u.ID)
                .HasConversion(idConvertor);

            builder.Property(typeof(UserName), "_userName")
                .HasMaxLength(50)
                .HasConversion(usernameConvertor)
                .HasColumnName("UserName")
                .IsRequired();

            builder.Property(typeof(Email), "_email")
                .HasConversion(emailConvertor)
                .HasColumnName("Email")
                .IsRequired();

            builder.Property(typeof(PasswordHash), "_passwordHash")
                .HasConversion(passwordHashConvertor)
                .HasColumnName("PasswordHash")
                .IsRequired();

            builder.Property(typeof(bool), "IsConfirmed")
                .HasColumnName("IsConfirmed")
                .IsRequired();

            builder.HasMany(typeof(UserRole), "_userRoles")
                .WithOne()
                .HasForeignKey("_userID");

            builder.HasMany(typeof(CourseAttendee), "_courseAttendees")
                .WithOne()
                .HasForeignKey("_userID");

        }

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
                .HasConversion(idConvertor);

            builder.Property(typeof(RoleName), "_roleName")
              .HasConversion(roleNameConvertor)
              .HasColumnName("RoleName")
              .IsRequired();

            builder.HasMany(typeof(UserRole), "_userRoles")
              .WithOne()
              .HasForeignKey("_userID");
        }

        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.Property(typeof(BaseId), "_roleID")
             .HasConversion(idConvertor)
             .HasColumnName("RoleID")
             .IsRequired();

            builder.HasOne<Role>()
              .WithMany()
              .HasForeignKey("_roleID");

            builder.Property(typeof(BaseId), "_userID")
             .HasConversion(idConvertor)
             .HasColumnName("UserID")
             .IsRequired();

            builder.HasOne<User>()
              .WithMany()
              .HasForeignKey("_userID");
        }
    }
}
