﻿using FluentValidation.Results;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Service.Base;

namespace PlayTechShop.Domain.Interface.Service;
public interface IClientService : IServiceBase<Client>
{
    Task<List<ValidationFailure>> ValidateClient(Client entity);
}