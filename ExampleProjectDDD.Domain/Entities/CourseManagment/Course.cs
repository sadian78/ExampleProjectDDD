using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class Course
    {
        public int ID {  get; set; }

        public List<CourseCatalog> CourseCataloges {  get; set; }
        public List<CourseAttendee> CourseAttendees {  get; set; }

        private Description _description;
        private Title _title;
        private Price _price;
        private BaseId _instructor_ID;
    }
}
