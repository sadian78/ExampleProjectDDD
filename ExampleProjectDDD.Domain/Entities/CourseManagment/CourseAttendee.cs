using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class CourseAttendee:BaseEntity
    {
        public CourseAttendee(BaseId id) : base(id) { }

        internal CourseAttendee(BaseId id, BaseId userID, BaseId courseID) : base(id)
        {
            _courseID = courseID;
            _userID = userID;
        }
        private BaseId _userID;
        private BaseId _courseID;

    }
}
