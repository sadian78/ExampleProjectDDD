using ExampleProjectDDD.Application.DTOs.UserManagment;
using ExampleProjectDDD.Application.Sevices;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.UserManagment.Handler
{
    public class GetUsersListHandler : IQueryHandler<GetUsersList, UsersListDTO>
    {
        private IUserReadModelServices _userReadModelServices;

        public GetUsersListHandler(IUserReadModelServices userReadModelServices)
        {
            _userReadModelServices = userReadModelServices;
        }
        public async Task<UsersListDTO> HandleAsync(GetUsersList query)
        {
            var users= (await _userReadModelServices.GetUserListAsync(query.UserName))
                .Select(u => u.ToDTO())
                .ToList();
            return new UsersListDTO()
            {
                Users= users
            };
        }
    }
}
