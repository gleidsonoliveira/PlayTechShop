using Microsoft.Extensions.DependencyInjection;
using PlayTechShop.Domain.Interface.Service;
using PlayTechShop.Service.Services;

namespace PlayTechShop.CrossCutting.DependencyInjection.Service;
public static class ServiceDependencyInjection
{
    public static IServiceCollection AddServiceDependency(this IServiceCollection services)
    {
        //return new ServiceCollection()
        //    .AddScoped<ICityService, CityService>()
        //    .AddScoped<ICompanyService, CompanyService>()
        //    .AddScoped<IInventoryService, InventoryService>()
        //    .AddScoped<IClientService, ClientService>()
        //    .AddScoped<IProductService, ProductService>()
        //    .AddScoped<ICategoryService, CategoryService>();

        return services.AddScoped<ICategoryService, CategoryService>();
    }
}
