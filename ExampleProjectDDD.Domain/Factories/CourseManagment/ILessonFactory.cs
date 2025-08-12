using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Factories.CourseManagment
{
    public interface ILessonFactory
    {
        Lesson CreateLesson(BaseId id, Title title, Content content, BaseId courseCatalogID);
    }
}
