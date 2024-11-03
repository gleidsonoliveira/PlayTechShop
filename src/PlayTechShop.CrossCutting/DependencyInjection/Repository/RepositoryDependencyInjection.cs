using Microsoft.Extensions.DependencyInjection;
using PlayTechShop.Data.Repository;
using PlayTechShop.Domain.Interface.Repository;

namespace PlayTechShop.CrossCutting.DependencyInjection.Repository;
public static class RepositoryDependencyInjection
{
    public static IServiceCollection AddSqlRepositorydependency()
    {
        return new ServiceCollection()
            .AddScoped<ICityRepository, CityRepository>();
        //.AddScoped<IStateRepository, StateRepository>();
    }
}
