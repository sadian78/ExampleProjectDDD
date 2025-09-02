namespace ExampleProjectDDD.Shared.Abstraction.Queries
{
    public interface IQueryDispacher
    {
        Task<TResult> DispacherAsync<TResult>(IQuery<TResult> query);
    }
}
