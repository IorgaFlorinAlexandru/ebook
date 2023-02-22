using Application.DataTransferObjects;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class CategoryController : ApiControllerBase
{
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CategoryDto>>> Get()
    {
        try
        {
            return Ok(await _categoryService.GetAllProductCategoriesAsync());
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<List<CategoryDto>>> GetById(Guid id)
    {
        try
        {
            return Ok(await _categoryService.GetCategoryByIdAsync(id));
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpPost]
    public async Task<ActionResult<CategoryDto>> Post([FromBody] CreateCategoryDto category)
    {
        try
        {
            var result = await _categoryService.CreateCategoryAsync(category);

            return CreatedAtRoute("", new { id = result.Id }, result);

        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(Guid id,[FromBody] CreateCategoryDto category)
    {
        try
        {
            await _categoryService.UpdateCategoryAsync(id,category);

            return Ok();
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid id)
    {
        try
        {
            await _categoryService.DeleteCategoryAsync(id);

            return Ok();
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

}