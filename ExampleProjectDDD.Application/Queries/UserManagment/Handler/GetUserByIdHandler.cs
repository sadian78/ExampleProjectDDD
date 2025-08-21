using ExampleProjectDDD.Application.DTOs.UserManagment;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.UserManagment.Handler
{
    public class GetUserByIdHandler : IQueryHandler<GetUserById, UserDTO>
    {
        public async Task<UserDTO> HandleAsync(GetUserById query)
        {
            throw new NotImplementedException();
        }
    }
}
