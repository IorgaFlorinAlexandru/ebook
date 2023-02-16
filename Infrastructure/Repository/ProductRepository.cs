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

    public List<Product> GetAllProducts()
    {
        return FindAll().Include(p => p.Category).AsNoTracking().ToList();
    }
}