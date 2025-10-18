using ExampleProjectDDD.Application.Sevices;
using ExampleProjectDDD.Domain.Entities.CourseManagment;

namespace ExampleProjectDDD.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAddNewCourse(Course course)
        {
            Task.CompletedTask.Wait();
        }

        public async Task SendEmailAddNewUser(string name, string text, string username, string password)
        {
            Task.CompletedTask.Wait();
        }
    }
}
