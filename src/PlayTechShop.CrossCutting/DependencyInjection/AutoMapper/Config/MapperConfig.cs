using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace PlayTechShop.CrossCutting.DependencyInjection.AutoMapper.Config;

public static class MapperConfig {

    public static IServiceCollection AddMapperConfiguration(this IServiceCollection services) {
        services.AddScoped<MappingProfile>();

        var config = new MapperConfiguration(cfg => {
            using (var serviceProvider = services.BuildServiceProvider()) {
                var factory = serviceProvider.GetRequiredService<MappingProfile>();
                
            }
        });

        IMapper mapper = config.CreateMapper();
        services.AddSingleton(mapper);

        return services;
    }
}