using Microsoft.EntityFrameworkCore;
using PlayTechShop.Data.Context;
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
        _ = entity ?? throw new ArgumentNullException(nameof(entity));

        if (entity is EntityBase entityBase)
        {
            if (entityBase.Situation == Situations.Inactive)
                entityBase.Situation = Situations.Inactive;
            else
                entityBase.Situation = Situations.Active;

            entityBase.DateCreated = DateTime.Now;
            entityBase.UserIdCreated = _currentUserService.UserId?.ToString();
        }

        await _vDensoContext.Set<TEntity>().AddAsync(entity);
        await _vDensoContext.SaveChangesAsync();
        return entity;
    }

    public virtual async Task AddRangeAsync(IList<TEntity> entities)
    {
        _ = entities ?? throw new ArgumentNullException(nameof(entities));

        var insertEntities = new List<TEntity>();
        foreach (var entity in entities)
        {
            if (entity is EntityBase entityBase)
            {
                entityBase.Situation = Situations.Active;
                entityBase.DateCreated = DateTime.Now;
                entityBase.UserIdCreated = _currentUserService.UserId?.ToString();
            }
            insertEntities.Add(entity);
        }

        await DbSet.AddRangeAsync(insertEntities);
        await _vDensoContext.SaveChangesAsync();
    }

    public virtual async Task<TEntity> DeleteAsync(long Id)
    {
        var entity = await _vDensoContext.Set<TEntity>().FindAsync(Id);
        _ = entity ?? throw new ArgumentNullException(nameof(entity));

        _vDensoContext.Set<TEntity>().Remove(entity);
        await _vDensoContext.SaveChangesAsync();

        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity));
        if (entity is EntityBase entityBase)
        {
            entityBase.DateDeleted = DateTime.Now;
            entityBase.Situation = Situations.Deleted;
            entityBase.UserIdDeleted = _currentUserService.UserId?.ToString();
        }

        _vDensoContext.Entry(entity).State = EntityState.Modified;
        await _vDensoContext.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<TEntity> PhysicalDeleteAsync(TEntity entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity));

        _vDensoContext.Set<TEntity>().Remove(entity);
        await _vDensoContext.SaveChangesAsync();

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

    public async Task<TEntity> GetByIdAsync(long Id)
    {
        var result = await _vDensoContext.Set<TEntity>().FindAsync(Id);
        return result;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        try
        {
            _ = entity ?? throw new ArgumentNullException(nameof(entity));

            if (entity is EntityBase entityBase)
            {
                switch (entityBase.Situation)
                {
                    case Situations.Deleted:
                        entityBase.DateDeleted = DateTime.Now;
                        entityBase.Situation = Situations.Deleted;
                        break;
                    case Situations.Active:
                        entityBase.DateModified = DateTime.Now;
                        entityBase.Situation = Situations.Active;
                        break;
                }

                entityBase.DateModified = DateTime.Now;
                entityBase.UserIdModified = _currentUserService.UserId?.ToString();
            }

            var entityIdProperty = typeof(TEntity).GetProperty("Id");
            if (entityIdProperty == null)
            {
                throw new InvalidOperationException("A entidade não possui uma propriedade 'Id'.");
            }

            var entityIdValue = entityIdProperty.GetValue(entity);

            var local = _vDensoContext.Set<TEntity>()
                                      .Local
                                      .FirstOrDefault(entry =>
                                          entityIdProperty.GetValue(entry).Equals(entityIdValue));

            if (local != null)
            {
                _vDensoContext.Entry(local).State = EntityState.Detached;
            }

            _vDensoContext.Entry(entity).State = EntityState.Modified;
            await _vDensoContext.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
    {
        _ = entities ?? throw new ArgumentNullException(nameof(entities));

        var updateEntities = new List<TEntity>();
        foreach (var entity in entities)
        {
            if (entity is EntityBase entityBase)
            {
                entityBase.DateModified = DateTime.Now;
                entityBase.UserIdModified = _currentUserService.UserId?.ToString();
            }
            _vDensoContext.Entry(entity).State = EntityState.Modified;
            updateEntities.Add(entity);
        }

        DbSet.UpdateRange(updateEntities);
        await _vDensoContext.SaveChangesAsync();
    }
}
