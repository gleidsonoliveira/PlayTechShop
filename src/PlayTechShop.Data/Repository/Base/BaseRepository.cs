using Microsoft.EntityFrameworkCore;
using PlayTechShop.Data.Context;
using PlayTechShop.Domain.Entities.Base;
using PlayTechShop.Domain.Enum;
using PlayTechShop.Domain.Interface.Repository.Base;
using System.Linq.Expressions;

namespace PlayTechShop.Data.Repository.Base;
public abstract class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    protected readonly PlayTechContext _vPlayTechContext;
    protected readonly DbSet<TEntity> DbSet;
    //private readonly ICurrentUserService _currentUserService;

    public BaseRepository(PlayTechContext pPlayTechContext)/*, ICurrentUserService currentUserService)*/
    {
        _vPlayTechContext = pPlayTechContext;
        DbSet = pPlayTechContext.Set<TEntity>();
        //_currentUserService = currentUserService;
    }

    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        if (entity is EntityBase entityBase)
        {
            entityBase.DateCreated = DateTime.Now;
            //entityBase.UserIdCreated = _currentUserService.UserId;
        }

        await _vPlayTechContext.Set<TEntity>().AddAsync(entity);
        await _vPlayTechContext.SaveChangesAsync();
        return entity;
    }

    public virtual async Task AddRangeAsync(IList<TEntity> entities)
    {
        try
        {

            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            var insertEntities = new List<TEntity>();
            foreach (var entity in entities)
            {
                if (entity is EntityBase entityBase)
                {
                    entityBase.Situation = Situation.Active;
                    entityBase.DateCreated = DateTime.Now;
                    //entityBase.UserIdCreated = _currentUserService.UserId;
                }
                insertEntities.Add(entity);
            }

            await DbSet.AddRangeAsync(insertEntities);
            await _vPlayTechContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public virtual async Task<TEntity> DeleteAsync(long Id)
    {
        var entity = await _vPlayTechContext.Set<TEntity>().FindAsync(Id);
        _ = entity ?? throw new ArgumentNullException(nameof(entity));

        _vPlayTechContext.Set<TEntity>().Remove(entity);
        await _vPlayTechContext.SaveChangesAsync();

        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity));
        if (entity is EntityBase entityBase)
        {
            entityBase.DateDeleted = DateTime.Now;
            entityBase.Situation = Situation.Deleted;
            //entityBase.UserIdDeleted = _currentUserService.UserId;
        }

        _vPlayTechContext.Entry(entity).State = EntityState.Modified;
        await _vPlayTechContext.SaveChangesAsync();
        return entity;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
    }

    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var result = await DbSet.AsNoTracking().Where(predicate).FirstOrDefaultAsync();
        return result;
    }

    public async Task<TEntity?> GetByIdAsync(long Id)
    {
        var result = await _vPlayTechContext.Set<TEntity>().FindAsync(Id);
        return result;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        try
        {
            if (entity is EntityBase entityBase)
            {
                entityBase.DateModified = DateTime.Now;
                //entityBase.UserIdModified = _currentUserService.UserId;
            }

            _vPlayTechContext.Entry(entity).State = EntityState.Modified;
            await _vPlayTechContext.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
    {
        if (entities == null)
            throw new ArgumentNullException(nameof(entities));

        var updateEntities = new List<TEntity>();
        foreach (var entity in entities)
        {
            if (entity is EntityBase entityBase)
            {
                entityBase.DateModified = DateTime.Now;
                //entityBase.UserIdModified = _currentUserService.UserId;
            }
            _vPlayTechContext.Entry(entity).State = EntityState.Modified;
            updateEntities.Add(entity);
        }

        DbSet.UpdateRange(updateEntities);
        await _vPlayTechContext.SaveChangesAsync();
    }


}
