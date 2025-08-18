using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment.Repository
{
    internal class CourseAttendeeFactory : ICourseAttendeeFactory
    {
        public CourseAttendee CreateCourseAttendee(BaseId id, BaseId userID, BaseId courseID)
        {
            return new CourseAttendee(id, userID, courseID);
        }
    }
}
