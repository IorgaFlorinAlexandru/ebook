using Application.DataTransferObjects;
using Application.Interfaces;
using Domain.Entities;
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
            return Ok(await _productService.GetProductByIdAsync(Id));
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ProductDto>> Post([FromBody] CreateProductDto product)
    {
            var result = await _productService.AddProductAsync(product);

            return CreatedAtRoute("", new { id = result.Id }, result);
        try
        {
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }


    [HttpPatch("{Id}/updatePrice")]
    public async Task<ActionResult> UpdatePrice(Guid Id,[FromBody] decimal price)
    {
        try
        {
            await _productService.UpdatePrice(Id,price);

            return Ok();
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    //TODO CATEGORY CONTROLLER + SERVICE + REPO
    [HttpPatch("{Id}/changeCategory")]
    public async Task<ActionResult> ChangeCategory(Guid Id,[FromBody] Guid CategoryId)
    {
        try
        {
            await Task.Delay(300);
            //await _productService.UpdatePrice(Id,price);

            return Ok();
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    [HttpPut]
    public ActionResult Put()
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public ActionResult Delete()
    {
        throw new NotImplementedException();
    }

}