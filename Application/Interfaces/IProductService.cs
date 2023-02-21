using Application.DataTransferObjects;
using Domain.Entities;

namespace Application.Interfaces;

public interface IProductService
{
    Task<List<ProductDto>> GetAllProductsAsync();
    Task<ProductDto> GetProductByIdAsync(Guid Id);
    Task AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task RemoveProductAsync(Guid Id);
    Task UpdatePrice(Guid Id, decimal price);
}