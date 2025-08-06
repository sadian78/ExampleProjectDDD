using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class CourseCatalog : BaseEntity
    {
        public CourseCatalog(BaseId id) : base(id) { }

        internal CourseCatalog(BaseId id, Title title, Description description, BaseId courseId) : base(id)
        {
            _title = title;
            _description = description;
            _courseId = courseId;
        }

        private Title _title;
        private Description _description;
        private BaseId _courseId;
        private LinkedList<Lesson> _lessons;
    }
}
