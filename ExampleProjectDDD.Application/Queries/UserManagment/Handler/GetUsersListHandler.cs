using ExampleProjectDDD.Application.DTOs.UserManagment;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.UserManagment.Handler
{
    public class GetUsersListHandler : IQueryHandler<GetUsersList, UsersListDTO>
    {
        public Task<UsersListDTO> HandleAsync(GetUsersList query)
        {
            throw new NotImplementedException();
        }
    }
}
