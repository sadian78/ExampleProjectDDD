using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Entities.UserManagment;

namespace ExampleProjectDDD.Domain.Entities.PaymentManagment
{
    public class Invoice
    {
        public int ID { get; set; }
        public decimal Amount {  get; set; }
        public DateTime Date { get; set; }
        public Guid UserID { get; set; }
        public User User { get; set; }
        public Course Course { get; set; }
        public int CourseID {  get; set; }
    }
}
