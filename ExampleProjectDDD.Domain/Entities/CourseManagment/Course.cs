using ExampleProjectDDD.Domain.DomainEvents;
using ExampleProjectDDD.Domain.Exceptions.CourseExceptions;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;
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
            RaiseDomainEvent(new NewCourseCreatedEvent(this));
        }

        private Description _description;
        private Title _title;
        private Price _price;
        private BaseId _instructor_ID;
        private LinkedList<CourseCatalog> _coursCataloges;
        private LinkedList<CourseAttendee> _coursAttendees;

        public void AddCourseAttendee(CourseAttendee courseAttendee)
        {
            if (courseAttendee == null)
            {
                throw new CourseAttendeeNullException();
            }
            var courseAttendeeExist = _coursAttendees.Any(a => a.Id == courseAttendee.Id);
            if (courseAttendeeExist)
            {
                throw new CourseAttendeeExistException();
            }
            _coursAttendees.AddLast(courseAttendee);
            RaiseDomainEvent(new AddCourseAttendeeEvent(courseAttendee));
        }

        public CourseAttendee GetCourseAttendee(BaseId courseAttendeeId)
        {
            var attendee = _coursAttendees.SingleOrDefault(c => c.Id == courseAttendeeId);
            if (attendee == null)
            {
                throw new CourseAttendeeAlreadyExistException();
            }
            return attendee;
        }

        public void RemoveCourseAttendee(BaseId courseAttendeeId)
        {
            var courseAttendee = GetCourseAttendee(courseAttendeeId);
            if (courseAttendee != null)
            {
                _coursAttendees.Remove(courseAttendee);
            }
        }
    }
}
