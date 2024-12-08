using AutoMapper;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Entities.Dtos;

namespace PlayTechShop.CrossCutting.DependencyInjection.AutoMapper;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<City, CityInsertRequestDto>().ReverseMap();
        CreateMap<City, CityUpdateRequestDto>().ReverseMap();

        CreateMap<Category, CategoryInsertRequestDto>().ReverseMap();
        CreateMap<Category, CategoryUpdateRequestDto>().ReverseMap();

        CreateMap<Product, ProductInsertRequestDto>().ReverseMap();
        CreateMap<Product, ProductUpdateRequestDto>().ReverseMap();
    }
}