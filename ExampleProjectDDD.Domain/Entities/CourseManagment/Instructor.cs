using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class Instructor : BaseEntity
    {
        public Instructor(BaseId id) : base(id) { }

        public Instructor(Name name, Bio bio,BaseId id) : base(id)
        {
            _name = name;
            _bio = bio;
            _exprience = 3;
            _rating = 0;
        }

        public Instructor(Name name, Bio bio,BaseId id, Exprience exprience) : base(id)
        {
            _name = name;
            _bio = bio;
            _exprience = exprience;
            _rating = 0;
        }

        public Instructor(Name name, Bio bio,BaseId id,Exprience exprience, Rating rating) : base(id)
        {
            _name = name;
            _bio = bio;
            _exprience = exprience;
            _rating= rating;
        }

        private Name _name;
        private Bio _bio;
        private LinkedList<Course> _courses;
        private Exprience _exprience;
        private Rating _rating;
    }
}
