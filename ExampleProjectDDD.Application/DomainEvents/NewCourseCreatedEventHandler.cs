using ExampleProjectDDD.Application.Sevices;
using ExampleProjectDDD.Domain.DomainEvents;
using ExampleProjectDDD.Shared.Abstraction.Domain;

namespace ExampleProjectDDD.Application.DomainEvents
{
    public class NewCourseCreatedEventHandler : IDomainEventHandler<NewCourseCreatedEvent>
    {
        private readonly IEmailService _emailService;
        public async Task HandleAsync(NewCourseCreatedEvent @event)
        {
         await  _emailService.SendEmailAddNewCourse(@event.course);
        }
    }
}
