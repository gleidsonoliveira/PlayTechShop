using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTechShop.CrossCutting.DependencyInjection.AutoMapper.Config;
public static class MapperConfig
{
    public static IServiceCollection AddMapperConfiguration(this IServiceCollection services)
    {
        services.AddScoped<MappingProfileFactory>();

        var config = new MapperConfiguration(cfg =>
        {
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var factory = serviceProvider.GetRequiredService<MappingProfileFactory>();
                foreach (var profile in factory.GetProfiles())
                {
                    cfg.AddProfile(profile);
                }
            }
        });

        IMapper mapper = config.CreateMapper();
        services.AddSingleton(mapper);

        return services;
    }
}

