using Domain.Entities;
using Domain.Exceptions;
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
        return await FindAll().Include(x => x.Category).AsNoTracking().ToListAsync();
    }

    public async Task<Product> GetProductByIdAsync(Guid Id)
    {
        var product = await FindByCondition(x => x.Id == Id).FirstOrDefaultAsync();

        if (product == null) throw new NotFoundException(nameof(Product), Id.ToString());

        return product;
    }

    public async Task<Product> GetProductByIdWithCategory(Guid Id)
    {
        var product = await FindByCondition(x => x.Id == Id).Include(x => x.Category).AsNoTracking().FirstOrDefaultAsync();

        if (product == null) throw new NotFoundException(nameof(Product), Id.ToString());

        return product;
    }

    public void CreateProduct(Product product)
    {
        Create(product);
    }

    public void RemoveProduct(Product product)
    {
        Delete(product);
    }

    public void UpdateProduct(Product product)
    {
        Update(product);
    }

    public Task<List<Product>> GetProductsByFilters()
    {
        throw new NotImplementedException();
    }
}