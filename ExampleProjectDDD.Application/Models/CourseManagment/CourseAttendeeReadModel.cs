using ExampleProjectDDD.Application.Models.UserManagmenet;

namespace ExampleProjectDDD.Application.Models.CourseManagment
{
    public class CourseAttendeeReadModel : BaseReadModel
    {
        public Guid UserID {  get; set; }
        public Guid CourseID {  get; set; }
        public UserReadModel User { get; set; }
        public CourseReadModel Course { get; set; }
  
    }
}
