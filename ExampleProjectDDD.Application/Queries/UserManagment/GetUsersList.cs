using ExampleProjectDDD.Application.DTOs.UserManagment;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.UserManagment
{
    public class GetUsersList : IQuery<UsersListDTO>
    {
        public string UserName { get; set; }
    }
}
