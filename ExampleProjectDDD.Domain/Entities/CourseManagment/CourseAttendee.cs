using ExampleProjectDDD.Domain.Entities.UserManagment;

namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class CourseAttendee
    {
        public int ID { get; set; }
        public User User{get;set;}
        public Guid UserID { get; set; }
        public Course Course {  get; set; }
        public int CourseID { get; set; }
    }
}
