
using ExampleProjectDDD.Shared.Abstraction.Commands;

namespace ExampleProjectDDD.Application.Commands.UserManagment.Handler
{
    public class AddUserCommandHandler : ICommandHandler<AddUserCommand>
    {
        public Task HandlerAsync(AddUserCommand command)
        {
            throw new NotImplementedException();
        }
    }
    public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand>
    {
        public Task HandlerAsync(UpdateUserCommand command)
        {
            throw new NotImplementedException();
        }
    }
    public class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        public Task HandlerAsync(DeleteUserCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
