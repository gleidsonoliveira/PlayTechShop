using Microsoft.Extensions.DependencyInjection;
using PlayTechShop.Data.Repository;
using PlayTechShop.Domain.Interface.Repository;
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
            .AddScoped<IInventoryService, InventoryService>()
             .AddScoped<IClientService, ClientService>();


        //.AddScoped<IStateService, StateService>();
    }
}
