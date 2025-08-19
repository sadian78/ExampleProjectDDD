namespace ExampleProjectDDD.Shared.Abstraction.Commands
{
    //in is not change TCommand and TCommand should be class and implimantation from ICommand
    public interface ICommandHandler<in TCommand> where TCommand:class,ICommand
    {
        Task HandlerAsync(TCommand command);
    }
}
