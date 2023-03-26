using Application.DataTransferObjects;
using Domain.Entities;

namespace Application.Interfaces;

public interface IProductService
{
    Task<List<ProductDto>> GetAllProductsAsync();
    Task<ProductDto> FindProductByIdAsync(Guid Id);
    Task<ProductDto> AddProductAsync(CreateProductDto product);
    Task UpdateProductAsync(Product product);
    Task RemoveProductAsync(Guid Id);
    Task UpdatePriceAsync(Guid Id, decimal price);
    Task UpdateCategoryAsync(Guid Id, Guid categoryId);
}