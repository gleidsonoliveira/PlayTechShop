using System.Linq.Expressions;

namespace PlayTechShop.Domain.Interface.Repository.Base;
public interface IRepositoryBase<TEntity> where TEntity : class
{
    Task<TEntity> AddAsync(TEntity entity);
    Task AddRangeAsync(IList<TEntity> entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task UpdateRangeAsync(IEnumerable<TEntity> entity);
    Task<TEntity> DeleteAsync(long Id);
    Task<TEntity> DeleteAsync(TEntity entity);
    Task<TEntity> GetByIdAsync(long Id);
    Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);

}
