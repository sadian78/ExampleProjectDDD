
namespace ExampleProjectDDD.Domain.ValueObject.Course
{
    public record Exprience
    {
        public double Value { get; }
        public Exprience(double value)
        {
            Value = value;
        }

        public static implicit operator double(Exprience exprience) => exprience.Value;
        public static implicit operator Exprience(double exprience) => new Exprience(exprience);
    }
}
