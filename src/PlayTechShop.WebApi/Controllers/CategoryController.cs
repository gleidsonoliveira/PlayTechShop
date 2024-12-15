
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Entities.Dtos;
using PlayTechShop.Domain.Interface.Service;
using Swashbuckle.AspNetCore.Annotations;

namespace PlayTechShop.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;
    public CategoryController(ICategoryService categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    [HttpPost(Name = "create-category")]
    [SwaggerOperation(Summary = "Cria uma categoria.")]
    [ProducesResponseType(typeof(CategoryFormResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    //[Authorize(Roles = "Admin,G")]
    public async Task<IActionResult> Create([FromBody] CategoryRequestInsertDto requestDto)
    {
        try
        {
            var category = _mapper.Map<Category>(requestDto);
            var result = await _categoryService.AddAsync(category);
            return Ok(result);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
