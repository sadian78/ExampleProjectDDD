using ExampleProjectDDD.Shared.Abstraction.Exceptions;

namespace ExampleProjectDDD.Domain.Exceptions.CourseExceptions
{
    internal class CourseAttendeeNullException : CourseManagementException
    {
        public CourseAttendeeNullException() : base("CourseAttendee is null")
        {

        }
    }
    internal class CourseAttendeeExistException : CourseManagementException
    {
        public CourseAttendeeExistException() : base("CourseAttendee is exist")
        {

        }
    }
    internal class CourseAttendeeAlreadyExistException : CourseManagementException
    {
        public CourseAttendeeAlreadyExistException() : base("CourseAttendee is exist")
        {

        }
    }
}
