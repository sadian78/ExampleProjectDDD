using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;
using ExampleProjectDDD.Shared.Abstraction.Commands;

namespace ExampleProjectDDD.Application.Commands.Course
{
    public record AddCourseCommand(BaseId id, Description description, Title title, Price price, BaseId instructor_ID) :ICommand;
    public record UpdateCourseCommand(BaseId id, Description description, Title title, Price price, BaseId instructor_ID) :ICommand;
    public record DeleteCourseCommand(BaseId id) :ICommand;
}
