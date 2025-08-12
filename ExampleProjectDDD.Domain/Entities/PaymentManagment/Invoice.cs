using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Invoice;

namespace ExampleProjectDDD.Domain.Entities.PaymentManagment
{
    public class Invoice : BaseEntity
    {
       
        public Invoice(BaseId id,Amount amount, DateTime date, BaseId userID, BaseId courseID):base(id)
        {
            _amount = amount;
            _date = date;
            _userID = userID;
            _courseID = courseID;
        }
        public Invoice(BaseId id) : base(id) { }

        private Amount _amount;
        private DateTime _date;
        private BaseId _userID;
        private BaseId _courseID;
    }
}
