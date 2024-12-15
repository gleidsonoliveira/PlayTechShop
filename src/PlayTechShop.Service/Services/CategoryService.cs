using FluentValidation;
using FluentValidation.Results;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Enum;
using PlayTechShop.Domain.Interface.Repository;
using PlayTechShop.Domain.Interface.Service;
using System.Linq.Expressions;

namespace PlayTechShop.Service.Services;
public class CategoryService : ICategoryService
{
    private readonly IValidator<Category> _vValidator;
    private readonly ICategoryRepository _repository;
    public CategoryService(ICategoryRepository repository, IValidator<Category> vValidator)
    {
        _repository = repository;
        _vValidator = vValidator;
    }
    public async Task<Category> AddAsync(Category entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity));

        var listErrors = await Validate(entity);

        if (listErrors.Any())
            throw new ValidationException(listErrors);

        return await _repository.AddAsync(entity);
    }

    public async Task AddRangeAsync(IList<Category> entity)
    {
        await _repository.AddRangeAsync(entity);
    }

    public async Task<Category> DeleteAsync(Category entity)
    {
        return await _repository.DeleteAsync(entity);
    }

    public async Task<Category> DeleteAsync(long Id)
    {
        return await _repository.DeleteAsync(Id);
    }

    public async Task<IEnumerable<Category>> GetAllAsync(Expression<Func<Category, bool>> predicate)
    {
        return await _repository.GetAllAsync(predicate);
    }

    public async Task<Category> GetAsync(Expression<Func<Category, bool>> predicate)
    {
        return await _repository.GetAsync(predicate);
    }

    public async Task<Category> GetByIdAsync(long Id)
    {
        return await _repository.GetByIdAsync(Id);
    }

    public async Task<Category> UpdateAsync(Category entity)
    {
        return await _repository.UpdateAsync(entity);
    }

    public async Task UpdateRangeAsync(IEnumerable<Category> entity)
    {
        await _repository.UpdateRangeAsync(entity);
    }

    public async Task<List<ValidationFailure>> Validate(Category entity)
    {
        var listErrors = new List<ValidationFailure>();

        var validation = _vValidator.Validate(entity);

        if (!validation.IsValid)
            listErrors.AddRange(validation.Errors);

        var isValidateEmail = await GetAsync(x => x.Description == entity.Description.Trim() && x.Situation == Situation.Active || x.Description == entity.Description.Trim() && x.Situation == Situation.Inactive);
        if (isValidateEmail is { } && isValidateEmail.Id > 0)
            listErrors.Add(new ValidationFailure("Categoria", $"Já existe uma descrição {(isValidateEmail.Situation == Situation.Active ? " ativa " : " inativa ")} cadastrada para essa categoria."));

        return listErrors;
    }
}
