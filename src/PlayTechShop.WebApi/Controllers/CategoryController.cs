
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Entities.Dtos;
using PlayTechShop.Domain.Interface.Service;
using Serilog;
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
    public async Task<IActionResult> Create([FromBody] CategoryRequestInsertDto requestDto)
    {
        try
        {
            var category = _mapper.Map<Category>(requestDto);
            var result = await _categoryService.AddAsync(category);
            return Ok(result);
        }
        catch (ValidationException e)
        {
            var vErros = e.Errors.Select(x => x.ErrorMessage).ToList();
            if (vErros is not null && vErros.Any())
                return BadRequest(new
                {
                    Errors = vErros
                });
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return Ok();
    }

    [HttpPut(Name = "update-category")]
    [SwaggerOperation(Summary = "Atualiza uma categoria.")]
    [ProducesResponseType(typeof(CategoryFormResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Update([FromQuery] long Id, [FromBody] CategoryUpdateRequestDto requestDto)
    {
        try
        {
            var category = await _categoryService.GetByIdAsync(Id);
            if (category is null)
                return NotFound("Categoria não cadastrada");

            var categoryUpdate = _mapper.Map(requestDto, category);

            var _category = await _categoryService.UpdateAsync(categoryUpdate);
            return Ok(_category);
        }
        catch (Exception ex)
        {
            Log.Error("Erro: {StackTrace} - {InnerException}", ex.StackTrace, ex.InnerException);
            return BadRequest(new { Errors = ex.Message });
        }
    }
}
