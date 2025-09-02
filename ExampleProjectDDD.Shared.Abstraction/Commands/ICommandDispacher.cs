namespace ExampleProjectDDD.Shared.Abstraction.Commands
{
    public interface ICommandDispacher
    {
        Task DispachAsync<TCommand>(TCommand command) where TCommand :class,ICommand;
    }
}
