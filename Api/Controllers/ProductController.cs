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
    public ActionResult<List<Product>> Get()
    {
        return Ok(_productService.GetAllProducts());
    }

    [HttpPost]
    public ActionResult Post([FromBody] Product product)
    {
        _productService.AddProduct(product);

        return Ok();
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