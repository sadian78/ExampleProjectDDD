using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment.Repository
{
    public class CourseFactory : ICourseFactory
    {
        public Course CreateCourse(BaseId id, Description description, Title title, Price price, BaseId instructor_ID)
        {
            return new Course(id,description,title,price,instructor_ID);
        }
    }
}
