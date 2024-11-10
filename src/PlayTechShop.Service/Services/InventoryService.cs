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
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _repository;
        public InventoryService(IInventoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Inventory> AddAsync(Inventory entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<Inventory> entity)
        {
            await _repository.AddRangeAsync(entity);
        }

        public async Task<Inventory> DeleteAsync(Inventory entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public async Task<Inventory> DeleteAsync(long Id)
        {
            return await _repository.DeleteAsync(Id);
        }

        public async Task<IEnumerable<Inventory>> GetAllAsync(Expression<Func<Inventory, bool>> predicate)
        {
            return await _repository.GetAllAsync(predicate);
        }

        public async Task<Inventory> GetAsync(Expression<Func<Inventory, bool>> predicate)
        {
            return await _repository.GetAsync(predicate);
        }

        public async Task<Inventory> GetByIdAsync(long Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public async Task<Inventory> UpdateAsync(Inventory entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task UpdateRangeAsync(IEnumerable<Inventory> entity)
        {
            await _repository.UpdateRangeAsync(entity);
        }
    }
}
