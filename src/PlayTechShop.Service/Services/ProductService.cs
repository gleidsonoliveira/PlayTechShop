using FluentValidation;
using FluentValidation.Results;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Enum;
using PlayTechShop.Domain.Interface.Repository;
using PlayTechShop.Domain.Interface.Service;
using PlayTechShop.Shared.Helpers;
using System.Linq.Expressions;

namespace PlayTechShop.Service.Services;
public class ProductService : IProductService
{
    private readonly IValidator<Product> _vValidator;
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository, IValidator<Product> vValidator)
    {
        _repository = repository;
        _vValidator = vValidator;
    }

    public async Task<Product> AddAsync(Product entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity));

        var listErrors = await Validate(entity);

        if (listErrors.Any())
            throw new ValidationException(listErrors);

        return await _repository.AddAsync(entity);
    }

    public async Task AddRangeAsync(IList<Product> entity)
    {
        await _repository.AddRangeAsync(entity);
    }

    public async Task<Product> DeleteAsync(Product entity)
    {
        return await _repository.DeleteAsync(entity);
    }

    public async Task<Product> DeleteAsync(long Id)
    {
        return await _repository.DeleteAsync(Id);
    }

    public async Task<IEnumerable<Product>> GetAllAsync(Expression<Func<Product, bool>> predicate)
    {
        return await _repository.GetAllAsync(predicate);
    }

    public async Task<Product> GetAsync(Expression<Func<Product, bool>> predicate)
    {
        return await _repository.GetAsync(predicate);
    }

    public async Task<Product> GetByIdAsync(long Id)
    {
        return await _repository.GetByIdAsync(Id);
    }

    public async Task<Product> UpdateAsync(Product entity)
    {
        return await _repository.UpdateAsync(entity);
    }

    public async Task UpdateRangeAsync(IEnumerable<Product> entity)
    {
        await _repository.UpdateRangeAsync(entity);
    }

    public async Task<List<ValidationFailure>> Validate(Product entity)
    {
        var listErrors = new List<ValidationFailure>();

        var validation = _vValidator.Validate(entity);

        if (!validation.IsValid)
            listErrors.AddRange(validation.Errors);

        var isValidateEmail = await GetAsync(x => x.Description.RemoveSpace() == entity.Description.RemoveSpace() && x.Situation == Situation.Active || x.Description.RemoveSpace() == entity.Description.RemoveSpace() && x.Situation == Situation.Inactive);
        if (isValidateEmail is { } && isValidateEmail.Id > 0)
            listErrors.Add(new ValidationFailure("Produto", $"Já existe uma descrição {(isValidateEmail.Situation == Situation.Active ? " ativa " : " inativa ")} cadastrada para esse produto."));

        return listErrors;
    }
}