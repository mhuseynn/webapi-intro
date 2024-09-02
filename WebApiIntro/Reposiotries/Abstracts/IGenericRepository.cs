using WebApiIntro.Entities.Abstracts;

namespace WebApiIntro.Reposiotries.Abstracts;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    Task<T?> GetAsync(int id);
    Task AddAsync(T entity);
    Task DeleteAsync(int id);
    Task<T> UpdateAsync(T entity);
    Task<IQueryable<T>> GetAllAsync();
    Task SaveAllChangesAsync();
}
