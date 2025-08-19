using ExampleProjectDDD.Application.Exceptions;
using ExampleProjectDDD.Domain.Factories.UserManagment;
using ExampleProjectDDD.Domain.Repositories.UserManagment;
using ExampleProjectDDD.Shared.Abstraction.Commands;

namespace ExampleProjectDDD.Application.Commands.UserManagment.Handler
{
    #region AddUserCommandHandler
    public class AddUserCommandHandler : ICommandHandler<AddUserCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IUserFactory _factory;

        public AddUserCommandHandler(IUserRepository repository, IUserFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public async Task HandlerAsync(AddUserCommand command)
        {
            var user = _factory.CreateUser(command.userName, command.passwordHash, command.email, command.id);
            await _repository.CreateAsync(user);
        }
    }

    #endregion

    #region UpdateUserCommandHandler
    public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IUserFactory _factory;

        public UpdateUserCommandHandler(IUserRepository repository, IUserFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public async Task HandlerAsync(UpdateUserCommand command)
        {
            var user = await _repository.GetAsync(command.id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            var userF=_factory.CreateUser(command.userName,command.passwordHash, command.email,command.id);
            await _repository.CreateAsync(user);
        }
    }

    #endregion

    #region DeleteUserCommandHandler
    public class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IUserFactory _factory;

        public DeleteUserCommandHandler(IUserRepository repository, IUserFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public async Task HandlerAsync(DeleteUserCommand command)
        {
            var user=await _repository.GetAsync(command.id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            await _repository.DeleteAsync(user);
        }
    }
    #endregion
}
