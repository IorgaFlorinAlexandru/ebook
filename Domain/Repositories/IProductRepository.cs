using Domain.Entities;

namespace Domain.Repositories;

public interface IProductRepository : IRepositoryBase<Product>
{
    Task<List<Product>> GetAllProductsAsync();
    Task<Product?> GetProductByIdAsync(Guid Id);
    Task<Product?> GetProductWithCategory(Guid Id);
    void CreateProduct(Product product);
    void UpdateProduct(Product product);
    void RemoveProduct(Product product);
}