using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Shared.Abstraction.Domain;

namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    //becuse this class is Aggregrate i impliment from AggregateRoot<T>
    public class Course : AggregateRoot<BaseId>
    {
        public Course() { }

        internal Course(BaseId id, Description description, Title title, Price price, BaseId instructor_ID)
        {
            //ID is AggregateRoot's property
            ID = id;
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
