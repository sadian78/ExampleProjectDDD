namespace ExampleProjectDDD.Domain.ValueObject.Course
{
    public record Price
    {
        public decimal Value {  get; }
        public Price(decimal value)
        {
            Value=value;
        }

        public static implicit operator decimal(Price title) => title.Value;
        public static implicit operator Price(decimal title) => new Price(title);
    }
}
