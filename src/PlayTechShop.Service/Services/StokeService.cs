using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;
using PlayTechShop.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlayTechShop.Service.Services
{
    public class StokeService : IStokeService
    {
        private readonly IStokeRepository _repository;
        public StokeService(IStokeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Stoke> AddAsync(Stoke entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<Stoke> entity)
        {
            await _repository.AddRangeAsync(entity);
        }

        public async Task<Stoke> DeleteAsync(Stoke entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public async Task<Stoke> DeleteAsync(long Id)
        {
            return await _repository.DeleteAsync(Id);
        }

        public async Task<IEnumerable<Stoke>> GetAllAsync(Expression<Func<Stoke, bool>> predicate)
        {
            return await _repository.GetAllAsync(predicate);
        }

        public async Task<Stoke> GetAsync(Expression<Func<Stoke, bool>> predicate)
        {
            return await _repository.GetAsync(predicate);
        }

        public async Task<Stoke> GetByIdAsync(long Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public async Task<Stoke> UpdateAsync(Stoke entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task UpdateRangeAsync(IEnumerable<Stoke> entity)
        {
            await _repository.UpdateRangeAsync(entity);
        }
    }
}
