using Microsoft.Extensions.DependencyInjection;
using PlayTechShop.Domain.Interface.Service;
using PlayTechShop.Service.Services;

namespace PlayTechShop.CrossCutting.DependencyInjection.Service;
public static class ServiceDependencyInjection
{
    public static IServiceCollection AddServiceDependency()
    {
        return new ServiceCollection()
            .AddScoped<ICityService, CityService>()
            .AddScoped<ICompanyService, CompanyService>()
            .AddScoped<IStokeService, StokeService>();


        //.AddScoped<IStateService, StateService>();
    }
}
