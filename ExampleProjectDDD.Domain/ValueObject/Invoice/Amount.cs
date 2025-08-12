
namespace ExampleProjectDDD.Domain.ValueObject.Invoice
{
    public record Amount
    {
        public decimal Value { get; }
        public Amount(decimal value)
        {
            Value = value;
        }

        public static implicit operator decimal(Amount amount) => amount.Value;
        public static implicit operator Amount(decimal amount) => new Amount(amount);
    }
}
