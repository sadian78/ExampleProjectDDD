using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.User;
using ExampleProjectDDD.Shared.Abstraction.Commands;

namespace ExampleProjectDDD.Application.Commands.UserManagment
{
    public record AddUserCommand(UserName userName, PasswordHash passwordHash, Email email, BaseId id) :ICommand;
    public record UpdateUserCommand(UserName userName, PasswordHash passwordHash, Email email, BaseId id) :ICommand;
    public record DeleteUserCommand(BaseId id) :ICommand;
}
