using ExampleProjectDDD.Application.DTOs.UserManagment;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.UserManagment
{
    public class GetUserById : IQuery<UserDTO>
    {
        public Guid Id { get; set; }
    }
}
