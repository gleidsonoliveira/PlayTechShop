using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.CrossCutting.DependencyInjection.Validation;
public static class ValidatorsDependencyInjection
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services.AddScoped<IValidator<City>, CityValidator>();
        services.AddScoped<IValidator<State>, StateValidator>();
        return services;
    }
}
