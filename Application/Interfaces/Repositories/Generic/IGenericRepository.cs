namespace Application.Interfaces.Repositories.Generic
{
    public interface IGenericRepository<TEntity>
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id);
        IQueryable<TEntity> GetQuery();
        Task UpdateAsync(TEntity entity, int id);
    }
}
