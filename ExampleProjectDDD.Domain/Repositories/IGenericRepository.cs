using ExampleProjectDDD.Domain.ValueObject;

namespace ExampleProjectDDD.Domain.Repositories
{
    public interface IGenericRepository<TEntity> 
        where TEntity : class
    {
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task<TEntity> GetAsync(BaseId Id);
        Task DeleteAsync(TEntity entity);
    }
}
