using Application.DataTransferObjects;
using Domain.Entities;

namespace Application.Interfaces;

public interface IProductService
{
    Task<List<ProductDto>> GetAllProductsAsync();
    Task<ProductDto> GetProductByIdAsync(Guid Id);
    Task<ProductDto> AddProductAsync(CreateProductDto product);
    Task UpdateProductAsync(Product product);
    Task RemoveProductAsync(Guid Id);
    Task UpdatePrice(Guid Id, decimal price);
    Task UpdateCategory(Guid Id, Guid categoryId);
}