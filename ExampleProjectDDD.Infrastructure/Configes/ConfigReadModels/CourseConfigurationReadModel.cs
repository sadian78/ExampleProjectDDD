using ExampleProjectDDD.Infrastructure.Models.CourseManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExampleProjectDDD.Infrastructure.Configes.ConfigReadModels
{
    internal sealed partial class ConfigurationReadModel : IEntityTypeConfiguration<CourseAttendeeReadModel>, IEntityTypeConfiguration<CourseCatalogReadModel>,
       IEntityTypeConfiguration<CourseReadModel>, IEntityTypeConfiguration<InstructorReadModel>,
       IEntityTypeConfiguration<LessonReadModel>
    {
        public void Configure(EntityTypeBuilder<CourseAttendeeReadModel> builder)
        {
            builder.ToTable("CourseAttendes");
            builder.HasKey(i => i.Id);
            //relation one to many but many in Course table
            builder.HasOne(c => c.Course)
                .WithMany(co => co.CourseAttendes)
                .HasForeignKey(c => c.CourseID);
            //relation one to many but many in User table
            builder.HasOne(c => c.User)
                .WithMany(u => u.CourseAttendees)
                .HasForeignKey(c => c.UserID);
        }

        public void Configure(EntityTypeBuilder<CourseCatalogReadModel> builder)
        {
            builder.ToTable("CourseCataloges");
            builder.HasKey(i => i.Id);
            builder.Property(c=>c.Title).IsRequired();
            builder.Property(c=>c.Description).IsRequired();
            //relation one to many but many in Course table
            builder.HasOne(c => c.Course)
                .WithMany(co => co.CoursCataloges)
                .HasForeignKey(c => c.Course_Id);
            //relation one to many but many in Lesson table
            builder.HasMany(c=>c.Lessons)
                .WithOne(l=>l.CourseCatalog)
                .HasForeignKey(l=>l.CourseCatalogId);
        }

        public void Configure(EntityTypeBuilder<CourseReadModel> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Description);
            builder.Property(c => c.Title);
            builder.Property(c => c.Price);
            //relation one to many (one in Course Table)
            builder.HasOne(c => c.Instructor)
              .WithMany(i=>i.Courses)
              .HasForeignKey(c=>c.Instructor_ID);
            //relation one to many but many in Course table
            builder.HasMany(c => c.CourseAttendes)
                .WithOne(ca => ca.Course)
                .HasForeignKey(ca => ca.CourseID);
            //relation one to many but many in Course table
            builder.HasMany(c=>c.CoursCataloges)
                .WithOne(cc=>cc.Course)
                .HasForeignKey(cc=>cc.Course_Id);
        }

        public void Configure(EntityTypeBuilder<InstructorReadModel> builder)
        {
            builder.ToTable("Instructors");
            builder.HasKey(i=>i.Id);
            builder.Property(i => i.Name).IsRequired();
            builder.Property(i => i.Bio);
            builder.Property(i => i.Exprience);
            builder.Property(i => i.Rating);
            //relation one to many but many in Instructor table
            builder.HasMany(i => i.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(c => c.Instructor_ID);
        }

        public void Configure(EntityTypeBuilder<LessonReadModel> builder)
        {
            builder.ToTable("Lessons");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Content);
            builder.Property(l => l.Title).IsRequired();
            //relation one to many but many in Course table
            builder.HasOne(l => l.CourseCatalog)
                .WithMany(cc => cc.Lessons)
                .HasForeignKey(l => l.CourseCatalogId);
        }
    }
}
