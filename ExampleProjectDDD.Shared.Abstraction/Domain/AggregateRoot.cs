
namespace ExampleProjectDDD.Shared.Abstraction.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T ID { get; protected set; }

        //for do you want know more you can read => Event Sourcing
        public int Version { get; protected set; }
        private bool _isIncremented;
        protected void IncrementVersion()
        {
            if (_isIncremented) return;
            Version++;
            _isIncremented = true;
        }
    }
}
