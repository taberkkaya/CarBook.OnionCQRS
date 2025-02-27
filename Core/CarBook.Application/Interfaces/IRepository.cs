using System.Linq.Expressions;

namespace CarBook.Application.Interfaces;

public interface IRepository<T> where T : class
{
    Task<List<T>?> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task RemoveAsync(T entity);
    Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
}