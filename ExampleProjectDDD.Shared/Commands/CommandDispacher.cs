using ExampleProjectDDD.Shared.Abstraction.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleProjectDDD.Shared.Commands
{
    internal sealed class CommandDispacher : ICommandDispacher
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandDispacher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        async Task ICommandDispacher.DispachAsync<TCommand>(TCommand command)
        {
            using var scope = _serviceProvider.CreateScope();
            var handle = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();
            await handle.HandlerAsync(command);
        }
    }
}
