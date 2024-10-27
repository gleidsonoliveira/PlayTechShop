using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;
using PlayTechShop.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlayTechShop.Service.Services;
public class CityService : ICityService
{
    private readonly ICityRepository _repository;
    public CityService(ICityRepository repository)
    {
        _repository = repository;
    }
    public async Task<City> AddAsync(City entity)
    {
        return await _repository.AddAsync(entity);
    }

    public async Task AddRangeAsync(IList<City> entity)
    {
        await _repository.AddRangeAsync(entity);
    }

    public async Task<City> DeleteAsync(City entity)
    {
        return await _repository.DeleteAsync(entity);
    }

    public async Task<City> DeleteAsync(long Id)
    {
        return await _repository.DeleteAsync(Id);
    }

    public async Task<IEnumerable<City>> GetAllAsync(Expression<Func<City, bool>> predicate)
    {
        return await _repository.GetAllAsync(predicate);
    }

    public async Task<ICollection<City>> GetAllCitiesofStateId(long StateId)
    {
        return await _repository.GetAllCitiesofStateId(StateId);
    }

    public async Task<City> GetAsync(Expression<Func<City, bool>> predicate)
    {
        return await _repository.GetAsync(predicate);
    }

    public async Task<City> GetByIdAsync(long Id)
    {
        var city = await _repository.GetByIdAsync(Id);
        if (city is { } && city.Id > 0)
            return city;
        return new();
    }

    public async Task<City> UpdateAsync(City entity)
    {
        return await _repository.UpdateAsync(entity);
    }

    public async Task UpdateRangeAsync(IEnumerable<City> entity)
    {
        await _repository.UpdateRangeAsync(entity);
    }
}
