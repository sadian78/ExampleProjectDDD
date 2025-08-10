using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Shared.Abstraction.Domain;

namespace ExampleProjectDDD.Domain.DomainEvents
{
    public record NewCourseCreatedEvent(Course course): IDomainEvent;
}
