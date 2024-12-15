using Microsoft.AspNetCore.Mvc;
using PlayTechShop.Domain.Entities.Dtos;
using PlayTechShop.Domain.Interface.Service;

namespace PlayTechShop.WebApi.Controllers;
public class ProductController : Controller
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }


    
}
