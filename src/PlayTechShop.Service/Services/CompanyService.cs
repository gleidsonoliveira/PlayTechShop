using FluentValidation.Results;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;
using PlayTechShop.Domain.Interface.Service;
using System.Linq.Expressions;

namespace PlayTechShop.Service.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _repository;
        public CompanyService(ICompanyRepository repository)
        {
            _repository = repository;
        }

        public async Task<Company> AddAsync(Company entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<Company> entity)
        {
            await _repository.AddRangeAsync(entity);
        }

        public async Task<Company> DeleteAsync(Company entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public async Task<Company> DeleteAsync(long Id)
        {
            return await _repository.DeleteAsync(Id);
        }

        public async Task<IEnumerable<Company>> GetAllAsync(Expression<Func<Company, bool>> predicate)
        {
            return await _repository.GetAllAsync(predicate);
        }

        public async Task<Company> GetAsync(Expression<Func<Company, bool>> predicate)
        {
            return await _repository.GetAsync(predicate);
        }

        public async Task<Company> GetByIdAsync(long Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public async Task<Company> UpdateAsync(Company entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task UpdateRangeAsync(IEnumerable<Company> entity)
        {
            await _repository.UpdateRangeAsync(entity);
        }

        public Task<List<ValidationFailure>> Validate(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
