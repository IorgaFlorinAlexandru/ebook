using Application.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services;

public class ProductService : IProductService
{
    private readonly IRepositoryWrapper _repository;
    public ProductService(IRepositoryWrapper repository)
    {
        _repository = repository;
    }

    public void AddProduct(Product product)
    {
        _repository.Product.Create(product);

        _repository.Save();
    }

    public List<Product> GetAllProducts()
    {
        return _repository.Product.GetAllProducts();
    }

    public Product GetProductById(Guid Id)
    {
        var product = _repository.Product.FindByCondition(x => x.Id == Id).FirstOrDefault();
        
        if(product == null) throw new Exception("Not Found");

        return product;
    }

    public void RemoveProduct(Guid Id)
    {
        var product = _repository.Product.FindByCondition(x => x.Id == Id).FirstOrDefault();
        
        if(product == null) throw new Exception("Not Found");

        _repository.Product.Delete(product);

        _repository.Save();
    }

    public void UpdateProduct(Product product)
    {
        _repository.Product.Update(product);

        _repository.Save();
    }
}