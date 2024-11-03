using AutoMapper;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Entities.Dtos.City;

namespace PlayTechShop.CrossCutting.DependencyInjection.AutoMapper;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<City, CityInsertRequestDto>().ReverseMap();
        CreateMap<City, CityUpdateRequestDto>().ReverseMap();
    }
}