using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class Instructor : BaseEntity
    {
        public Instructor(BaseId id) : base(id) { }

        public Instructor(Name name, Bio bio,BaseId id) : base(id)
        {
            _name = name;
            _bio = bio;
        }

        private Name _name;
        private Bio _bio;
        private LinkedList<Course> _courses;
    }
}
