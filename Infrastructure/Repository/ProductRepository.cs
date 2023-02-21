using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context)
     : base(context)
    {
    }

    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await FindAll().AsNoTracking().ToListAsync();
    }

    public async Task<Product?> GetProductByIdAsync(Guid Id)
    {
        return await FindByCondition(x => x.Id == Id).Include(x => x.Category).FirstOrDefaultAsync();
    }

    public async Task<Product?> GetProductWithCategory(Guid Id)
    {
        return await FindByCondition(x => x.Id == Id).Include(x => x.Category).FirstOrDefaultAsync();
    }

    public void CreateProduct(Product product)
    {
        Create(product);
    }

    public void RemoveProduct(Product product)
    {
        RemoveProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        UpdateProduct(product);
    }
}