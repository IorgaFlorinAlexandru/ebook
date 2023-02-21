using Domain.Entities;

namespace Domain.Repositories;

public interface IProductRepository : IRepositoryBase<Product>
{
    Task<List<Product>> GetAllProductsAsync();
    Task<Product?> GetProductByIdAsync(Guid Id);
    Task<Product?> GetProductByIdWithCategory(Guid Id);
    Task<List<Product>> GetProductsByFilters();
    void CreateProduct(Product product);
    void UpdateProduct(Product product);
    void RemoveProduct(Product product);
}