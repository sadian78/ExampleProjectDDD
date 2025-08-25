using ExampleProjectDDD.Infrastructure.Models.CourseManagment;
using ExampleProjectDDD.Infrastructure.Models.UserManagmenet;

namespace ExampleProjectDDD.Infrastructure.Models.PaymentManagment
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
