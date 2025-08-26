using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExampleProjectDDD.Infrastructure.Configes.ConfigWriteModels
{
    internal sealed partial class ConfigurationWriteModel : IEntityTypeConfiguration<Course>, IEntityTypeConfiguration<CourseAttendee>,
        IEntityTypeConfiguration<CourseCatalog>, IEntityTypeConfiguration<Instructor>, IEntityTypeConfiguration<Lesson>
    {
        private ValueConverter idConvertor = new ValueConverter<BaseId, Guid>(id => id.Value, id => new BaseId(id));
        private ValueConverter descriptionConvertor = new ValueConverter<Description, string>(des => des.Value, des => new Description(des));
        private ValueConverter titleConvertor = new ValueConverter<Title, string>(title => title.Value, title => new Title(title));
        private ValueConverter priceConvertor = new ValueConverter<Price, decimal>(price => price.Value, price => new Price(price));
        private ValueConverter nameConvertor = new ValueConverter<Name, string>(name => name.Value, name => new Name(name));
        private ValueConverter bioConvertor = new ValueConverter<Bio, string>(bio => bio.Value, bio => new Bio(bio));
        private ValueConverter exprienceConvertor = new ValueConverter<Exprience, double>(exprience => exprience.Value, exprience => new Exprience(exprience));
        private ValueConverter ratingConvertor = new ValueConverter<Rating, double>(rating => rating.Value, rating => new Rating(rating));
        private ValueConverter contentConvertor = new ValueConverter<Content, string>(content => content.Value, content => new Content(content));

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID)
                .HasConversion(idConvertor);

            builder.Property(typeof(Description), "_description")
                .HasConversion(descriptionConvertor)
                .HasColumnName("Description")
                .IsRequired();

            builder.Property(typeof(Title), "_title")
                .HasConversion(titleConvertor)
                .HasColumnName("Title")
                .IsRequired();

            builder.Property(typeof(Price), "_price")
                .HasConversion(priceConvertor)
                .HasColumnName("Price");

            builder.Property(typeof(BaseId), "_instructor_ID")
                .HasConversion(idConvertor)
                .HasColumnName("Instructor_ID");

            builder.HasOne<Instructor>()
                .WithMany()
                .HasForeignKey("_instructor_ID")
                .IsRequired();

            builder.HasMany(typeof(CourseAttendee), "_coursAttendees")
                .WithOne()
                .HasForeignKey("_courseID");

            builder.HasMany(typeof(CourseCatalog), "_coursCataloges")
                .WithOne()
                .HasForeignKey("_courseId");
        }

        public void Configure(EntityTypeBuilder<CourseAttendee> builder)
        {
            builder.ToTable("CourseAttendee");
            builder.HasKey(ca => ca.Id);
            builder.Property(ca => ca.Id)
                .HasConversion(idConvertor);

            builder.Property(typeof(BaseId), "_userID")
             .HasConversion(idConvertor)
             .HasColumnName("_userID");

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey("_userID");

            builder.Property(typeof(BaseId), "_courseID")
              .HasConversion(idConvertor)
              .HasColumnName("_courseID");

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey("_courseID");

        }

        public void Configure(EntityTypeBuilder<CourseCatalog> builder)
        {
            builder.ToTable("CourseCatalogs");
            builder.HasKey(cc => cc.Id);
            builder.Property(cc => cc.Id)
                .HasConversion(idConvertor);

            builder.Property(typeof(Title), "_title")
                .HasConversion(titleConvertor)
                .HasColumnName("Title")
                .IsRequired();

            builder.Property(typeof(Description), "_description")
                .HasConversion(descriptionConvertor)
                .HasColumnName("Description")
                .IsRequired();

            builder.Property(typeof(BaseId), "_courseId")
               .HasConversion(idConvertor)
               .HasColumnName("_courseId");

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey("_courseId");

            builder.HasMany(typeof(Lesson), "_lessons")
                .WithOne()
                .HasForeignKey("_courseCatalogID");
        }

        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .HasConversion(idConvertor);

            builder.Property(typeof(Name), "_name")
                .HasConversion(nameConvertor)
                .HasColumnName("Name")
                .IsRequired();

            builder.Property(typeof(Bio), "_bio")
                .HasConversion(bioConvertor)
                .HasColumnName("Bio");

            builder.Property(typeof(Exprience), "_exprience")
                .HasConversion(exprienceConvertor)
                .HasColumnType("Exprience");

            builder.Property(typeof(Rating), "_rating")
                .HasConversion(ratingConvertor)
                .HasColumnName("Rating");

            builder.HasMany(typeof(Course), "_courses")
                .WithOne()
                .HasForeignKey("_instructor_ID");
        }

        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("Lessons");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id)
                .HasConversion(idConvertor);

            builder.Property(typeof(Title), "_title")
                .HasConversion(titleConvertor)
                .HasColumnName("Title")
                .IsRequired();

            builder.Property(typeof(Content), "_content")
                .HasConversion(contentConvertor)
                .HasColumnName("Content");

            builder.Property(typeof(BaseId), "_courseCatalogID")
                .HasConversion(idConvertor)
                .HasColumnName("_courseCatalogID");

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey("_courseCatalogID");
        }
    }
}
