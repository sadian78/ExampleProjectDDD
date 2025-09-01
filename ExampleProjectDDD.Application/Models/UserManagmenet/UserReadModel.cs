using ExampleProjectDDD.Application.Models.CourseManagment;
using ExampleProjectDDD.Application.Models.PaymentManagment;

namespace ExampleProjectDDD.Application.Models.UserManagmenet
{
    public class UserReadModel : BaseReadModel
    {
        public string UserName { get; set; } 
        public string PasswordHash { get; set; } 
        public string Email { get; set; } 
        public bool IsConfirmed { get; set; } 
        public IReadOnlyList<UserRoleReadModel> UserRoles { get; set; }
        public IReadOnlyList<InvoiceReadModel> Invoices { get; set; }
        public IReadOnlyList<CourseAttendeeReadModel> CourseAttendees { get; set; }
    }
}
