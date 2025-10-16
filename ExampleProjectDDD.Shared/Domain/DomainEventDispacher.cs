using ExampleProjectDDD.Shared.Abstraction.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleProjectDDD.Shared.DomainEvent
{
    public class DomainEventDispacher : IDomainEventDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public DomainEventDispacher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        async Task IDomainEventDispatcher.DispatchAsync<TEvent>(TEvent @event)
        {
            using var scope = _serviceProvider.CreateScope();

            var handler = scope.ServiceProvider.GetRequiredService<IDomainEventHandler<TEvent>>();

            await handler.HandleAsync(@event);
        }
    }
}
