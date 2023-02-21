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
    public async Task<ActionResult<List<Product>>> Get()
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
    public async Task<ActionResult<Product>> GetById(Guid Id)
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
    public async Task<ActionResult<Product>> Post([FromBody] Product product)
    {
        try
        {
            await _productService.AddProductAsync(product);

            return CreatedAtRoute("", new { id = product.Id }, product);
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