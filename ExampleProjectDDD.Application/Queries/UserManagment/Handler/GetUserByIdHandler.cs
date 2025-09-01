using ExampleProjectDDD.Application.DTOs.UserManagment;
using ExampleProjectDDD.Application.Sevices;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.UserManagment.Handler
{
    public class GetUserByIdHandler : IQueryHandler<GetUserById, UserDTO>
    {
        private IUserReadModelServices _userReadModelServices;

        public GetUserByIdHandler(IUserReadModelServices userReadModelServices)
        {
            _userReadModelServices = userReadModelServices;
        }

        public async Task<UserDTO> HandleAsync(GetUserById query)
        {
            return (await _userReadModelServices.GetUserByIdAsync(query.Id)).ToDTO();
        }
    }
}
