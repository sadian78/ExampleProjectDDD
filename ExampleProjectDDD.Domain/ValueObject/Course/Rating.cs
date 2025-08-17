
namespace ExampleProjectDDD.Domain.ValueObject.Course
{
    public record Rating
    {
        public double Value { get; }
        public Rating(double value)
        {
            Value = value;
        }

        public static implicit operator double(Rating rating) => rating.Value;
        public static implicit operator Rating(double rating) => new Rating(rating);
    } 
}
