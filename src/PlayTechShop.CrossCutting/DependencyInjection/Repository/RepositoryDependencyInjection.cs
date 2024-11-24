using Microsoft.Extensions.DependencyInjection;
using PlayTechShop.Data.Repository;
using PlayTechShop.Domain.Interface.Repository;

namespace PlayTechShop.CrossCutting.DependencyInjection.Repository;
public static class RepositoryDependencyInjection
{
    public static IServiceCollection AddSqlRepositorydependency(this IServiceCollection services)
    {
        return new ServiceCollection()
            .AddScoped<ICityRepository, CityRepository>()
            .AddScoped<ICompanyRepository, CompanyRepository>()
            .AddScoped<IInventoryRepository, InventoryRepository>()
            .AddScoped<IClientRepository, ClientRepository>();

        //.AddScoped<IStateRepository, StateRepository>();

    }
}
