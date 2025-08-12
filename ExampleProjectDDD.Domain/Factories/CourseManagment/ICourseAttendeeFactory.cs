using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment
{
    public interface ICourseAttendeeFactory
    {
        CourseAttendee CreateCourseAttendee(BaseId id, BaseId userID, BaseId courseID)
    }
}
