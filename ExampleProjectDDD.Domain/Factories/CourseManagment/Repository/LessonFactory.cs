
using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment.Repository
{
    public class LessonFactory : ILessonFactory
    {
        public Lesson CreateLesson(BaseId id, Title title, Content content, BaseId courseCatalogID)
        {
            return new Lesson(id, title, content, courseCatalogID);
        }
    }
}
