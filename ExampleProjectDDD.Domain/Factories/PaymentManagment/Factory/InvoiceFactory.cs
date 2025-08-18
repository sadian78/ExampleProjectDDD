using ExampleProjectDDD.Domain.Entities.PaymentManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Invoice;

namespace ExampleProjectDDD.Domain.Factories.PaymentManagment.Repository
{
    public class InvoiceFactory : IInvoiceFactory
    {
        public Invoice CreateInvoice(BaseId id, Amount amount, DateTime date, BaseId userID, BaseId courseID)
        {
            return new Invoice(id, amount, date, userID, courseID);
        }
    }
}
