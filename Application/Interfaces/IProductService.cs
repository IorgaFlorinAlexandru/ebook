using Domain.Entities;

namespace Application.Interfaces;

public interface IProductService
{
    List<Product> GetAllProducts();
    Product GetProductById(Guid Id);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void RemoveProduct(Guid Id);
}