using ExampleProjectDDD.Application.Models.CourseManagment;
using ExampleProjectDDD.Application.Models.UserManagmenet;

namespace ExampleProjectDDD.Application.Models.PaymentManagment
{
    public class InvoiceReadModel : BaseReadModel
    {
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }
        public Guid UserID { get; set; }
        public UserReadModel User { get; set; }
        public Guid CourseID { get; set; }
        public CourseReadModel Course { get; set; }
    }
}
