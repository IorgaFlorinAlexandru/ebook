using Domain.Entities;

namespace Application.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetAllProductsAsync();
    Task<Product> GetProductByIdAsync(Guid Id);
    Task AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task RemoveProductAsync(Guid Id);
}