using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Shared.Abstraction.Domain;

namespace ExampleProjectDDD.Domain.DomainEvents
{
    public record AddCourseAttendeeEvent(CourseAttendee courseAttendee) : IDomainEvent;
}
