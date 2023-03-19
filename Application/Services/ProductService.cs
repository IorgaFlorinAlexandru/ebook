using Application.DataTransferObjects;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

namespace Application.Services;

public class ProductService : IProductService
{
    private readonly IRepositoryWrapper _repository;
    private readonly IMapper _mapper;
    public ProductService(IRepositoryWrapper repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ProductDto> AddProductAsync(CreateProductDto product)
    {
        var productEntity = _mapper.Map<Product>(product);

        _repository.Product.CreateProduct(productEntity);

        await _repository.SaveAsync();

        var createdProduct = _mapper.Map<ProductDto>(productEntity);

        return createdProduct;
    }

    public async Task<List<ProductDto>> GetAllProductsAsync()
    {
        var products = await _repository.Product.GetAllProductsAsync();

        var productsResult = _mapper.Map<List<ProductDto>>(products);

        return productsResult;
    }

    public async Task<ProductDto> GetProductByIdAsync(Guid Id)
    {
        var product = await _repository.Product.GetProductByIdWithCategory(Id);

        var productResult = _mapper.Map<ProductDto>(product);

        return productResult;
    }

    public async Task RemoveProductAsync(Guid Id)
    {
        var product = await _repository.Product.GetProductByIdAsync(Id);

        _repository.Product.RemoveProduct(product);

        await _repository.SaveAsync();
    }

    public async Task UpdatePriceAsync(Guid Id, decimal price)
    {
        var product = await _repository.Product.GetProductByIdAsync(Id);

        product.Price = price;

        _repository.Product.UpdateProduct(product);

        await _repository.SaveAsync();
    }

    public async Task UpdateCategoryAsync(Guid Id, Guid categoryId)
    {
        var product = await _repository.Product.GetProductByIdAsync(Id);

        var category = await _repository.Category.GetCategoryById(categoryId);

        product.Category = category;

        _repository.Product.UpdateProduct(product);

        await _repository.SaveAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        _repository.Product.UpdateProduct(product);

        await _repository.SaveAsync();
    }

}