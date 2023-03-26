using Application.DataTransferObjects;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class ProductController : ApiControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ProductDto>>> Get()
    {
        try
        {
            return Ok(await _productService.GetAllProductsAsync());
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<ProductDto>> GetById(Guid Id)
    {
        try
        {
            return Ok(await _productService.FindProductByIdAsync(Id));
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ProductDto>> Post([FromBody] CreateProductDto product)
    {
        try
        {
            var result = await _productService.AddProductAsync(product);

            return CreatedAtRoute("", new { id = result.Id }, result);
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }


    [HttpPut("{id}")]
    public ActionResult Put(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(Guid id)
    {
        throw new NotImplementedException();
    }


    [HttpPatch("{Id}/price")]
    public async Task<ActionResult> UpdatePrice(Guid Id, [FromBody] decimal price)
    {
        try
        {
            await _productService.UpdatePriceAsync(Id, price);

            return Ok();
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpPatch("{Id}/category")]
    public async Task<ActionResult> ChangeCategory(Guid Id, [FromBody] Guid CategoryId)
    {
        try
        {
            await _productService.UpdateCategoryAsync(Id, CategoryId);

            return Ok();
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpPatch("{Id}/image")]
    public async Task<ActionResult> ChangeImageOfProduct(Guid Id, [FromBody] string ImageUrl)
    {
        try
        {
            await Task.Delay(3000);
            throw new NotImplementedException();
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

}