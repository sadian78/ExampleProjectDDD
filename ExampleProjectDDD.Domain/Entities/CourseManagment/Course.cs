using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class Course:BaseEntity
    {
        public Course(BaseId id):base(id) { }

        internal Course(BaseId id,Description description, Title title, Price price, BaseId instructor_ID):base(id)
        {
            _description = description;
            _title = title; 
            _price = price;
            _instructor_ID = instructor_ID;
        }

        private Description _description;
        private Title _title;
        private Price _price;
        private BaseId _instructor_ID;
        private LinkedList<CourseCatalog> _coursCataloges;
        private LinkedList<CourseAttendee> _coursAttendees;
    }
}
