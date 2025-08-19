using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.User;
using ExampleProjectDDD.Shared.Abstraction.Commands;

namespace ExampleProjectDDD.Application.Commands.UserManagment
{
    public record CreateUserCommands(UserName userName, PasswordHash passwordHash, Email email, BaseId id) :ICommand;
    public record UpdateUserCommands(UserName userName, PasswordHash passwordHash, Email email, BaseId id) :ICommand;
    public record DeleteUserCommands(BaseId id) :ICommand;
}
