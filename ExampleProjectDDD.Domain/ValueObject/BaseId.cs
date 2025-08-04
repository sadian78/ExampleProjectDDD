using ExampleProjectDDD.Domain.Exceptions;

namespace ExampleProjectDDD.Domain.ValueObject
{
    public record BaseId
    {
        public Guid Value { get;  }
        public BaseId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new BaseIdNullExceptions();
            }
            Value = value;
        }

        public static implicit operator Guid(BaseId id) => id.Value;
        public static implicit operator BaseId(Guid id) => new BaseId(id);
    }
}
