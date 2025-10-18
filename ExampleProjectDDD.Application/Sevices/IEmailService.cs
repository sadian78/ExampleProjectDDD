using ExampleProjectDDD.Domain.Entities.CourseManagment;

namespace ExampleProjectDDD.Application.Sevices
{
    public interface IEmailService
    {
        Task SendEmailAddNewCourse(Course course);
        Task SendEmailAddNewUser(string name, string text, string username, string password);
    }
}
