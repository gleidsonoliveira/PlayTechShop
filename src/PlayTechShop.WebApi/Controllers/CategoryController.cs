using Microsoft.AspNetCore.Mvc;
using PlayTechShop.Domain.Interface.Service;

namespace PlayTechShop.WebApi.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
