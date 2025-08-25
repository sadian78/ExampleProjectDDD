using ExampleProjectDDD.Infrastructure.Models.UserManagmenet;

namespace ExampleProjectDDD.Infrastructure.Models.CourseManagment
{
    public class CourseAttendeeReadModel : BaseReadModel
    {
        public Guid UserID {  get; set; }
        public Guid CourseID {  get; set; }
        public UserReadModel User { get; set; }
        public CourseReadModel Course { get; set; }
  
    }
}
