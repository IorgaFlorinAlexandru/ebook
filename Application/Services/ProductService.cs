using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

namespace Application.Services;

public class ProductService : IProductService
{
    private readonly IRepositoryWrapper _repository;
    public ProductService(IRepositoryWrapper repository)
    {
        _repository = repository;
    }

    public async Task AddProductAsync(Product product)
    {
        _repository.Product.CreateProduct(product);

        await _repository.SaveAsync();
    }

    public async Task< List<Product>> GetAllProductsAsync()
    {
        return await _repository.Product.GetAllProductsAsync();
    }

    public async Task<Product> GetProductByIdAsync(Guid Id)
    {
        var product = await _repository.Product.GetProductByIdAsync(Id);

        if (product == null) throw new NotFoundException(nameof(Product),Id.ToString());

        return product;
    }

    public async Task RemoveProductAsync(Guid Id)
    {
        var product = await _repository.Product.GetProductByIdAsync(Id);

        if (product == null) throw new NotFoundException(nameof(Product),Id.ToString());

        _repository.Product.RemoveProduct(product);

        await _repository.SaveAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        _repository.Product.UpdateProduct(product);

        await _repository.SaveAsync();
    }
}