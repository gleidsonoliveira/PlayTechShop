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

        #region Category
        CreateMap<Category, CategoryRequestInsertDto>().ReverseMap();
        CreateMap<Category, CategoryUpdateRequestDto>().ReverseMap();
        CreateMap<Category, CategoryFormResponseDto>().ReverseMap(); 
        #endregion

        CreateMap<Product, ProductInsertRequestDto>().ReverseMap();
        CreateMap<Product, ProductUpdateRequestDto>().ReverseMap();
    }
}