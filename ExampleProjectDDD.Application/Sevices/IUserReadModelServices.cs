namespace ExampleProjectDDD.Application.Sevices
{
    public interface IUserReadModelServices
    {
        Task<bool> IsExistUserAsync(string username);
    }
}
