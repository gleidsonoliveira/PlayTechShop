using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;
using PlayTechShop.Domain.Interface.Service;
using System.Linq.Expressions;
using FluentValidation;
using FluentValidation.Results;
using PlayTechShop.Domain.Enum;
using PlayTechShop.Shared.Helpers;

namespace PlayTechShop.Service.Services;
public class ClientService : IClientService
{
    private readonly IValidator<Client> _vValidator;
    private readonly IClientRepository _repository;
    public ClientService(IClientRepository repository, IValidator<Client> Validator)
    {
        _repository = repository;
        _vValidator = Validator;
    }

    public async Task<Client> AddAsync(Client entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity));

        var listErrors = await Validate(entity);

        if (listErrors.Any())
            throw new ValidationException(listErrors);

        return await _repository.AddAsync(entity);
    }

    public async Task AddRangeAsync(IList<Client> entity)
    {
        await _repository.AddRangeAsync(entity);
    }

    public async Task<Client> DeleteAsync(Client entity)
    {
        return await _repository.DeleteAsync(entity);
    }

    public async Task<Client> DeleteAsync(long Id)
    {
        return await _repository.DeleteAsync(Id);
    }

    public async Task<IEnumerable<Client>> GetAllAsync(Expression<Func<Client, bool>> predicate)
    {
        return await _repository.GetAllAsync(predicate);
    }

    public async Task<Client> GetAsync(Expression<Func<Client, bool>> predicate)
    {
        return await _repository.GetAsync(predicate);
    }

    public async Task<Client> GetByIdAsync(long Id)
    {
        var Client = await _repository.GetByIdAsync(Id);
        if (Client is { } && Client.Id > 0)
            return Client;
        return new();
    }

    public async Task<Client> UpdateAsync(Client entity)
    {
        return await _repository.UpdateAsync(entity);
    }

    public async Task UpdateRangeAsync(IEnumerable<Client> entity)
    {
        await _repository.UpdateRangeAsync(entity);
    }

    public async Task<List<ValidationFailure>> Validate(Client entity)
    {
        var listErrors = new List<ValidationFailure>();

        var validation = _vValidator.Validate(entity);

        if (!validation.IsValid)
            listErrors.AddRange(validation.Errors);

        var isValidateEmail = await GetAsync(x => x.Email.RemoveSpace() == entity.Email.RemoveSpace() && x.Situation == Situation.Active || x.Email.RemoveSpace() == entity.Email.RemoveSpace() && x.Situation == Situation.Inactive);
        if (isValidateEmail is { } && isValidateEmail.Id > 0)
            listErrors.Add(new ValidationFailure("Client", $"Já existe um email {(isValidateEmail.Situation == Situation.Active ? " ativo " : " inativo ")} cadastrado para esse cliente."));

        var isValidateCpf = await GetAsync(x => x.Cpf.RemoveScore() == entity.Cpf.RemoveScore() && x.Situation == Situation.Active || x.Email.RemoveScore() == entity.Cpf.RemoveScore() && x.Situation == Situation.Inactive);
        if (isValidateCpf is { } && isValidateCpf.Id > 0)
            listErrors.Add(new ValidationFailure("Client", $"Já existe um cpf {(isValidateCpf.Situation == Situation.Active ? " ativo " : " inativo ")} cadastrado para esse cliente."));

        return listErrors;
    }
}
