using ExampleProjectDDD.Domain.Entities.PaymentManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Invoice;

namespace ExampleProjectDDD.Domain.Factories.PaymentManagment
{
    public interface IInvoiceFactory
    {
        Invoice CreateInvoice(BaseId id, Amount amount, DateTime date, BaseId userID, BaseId courseID);
    }
}
