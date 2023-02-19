using Domain.Repositories;
using Infrastructure.Persistence;

namespace Infrastructure.Repository;

public class RepositoryWrapper : IRepositoryWrapper
{
    private ApplicationDbContext _context;
    private IProductRepository? _product;
    private ICategoryRepository? _category;
    private ICartRepository? _cart;
    private IOrderRepository? _order;

    public RepositoryWrapper(ApplicationDbContext context)
    {
        _context = context;
    }

    public IProductRepository Product
    {
        get
        {
            if (_product == null)
                _product = new ProductRepository(_context);
            return _product;
        }
    }

    public ICategoryRepository Category
    {
        get
        {
            if (_category == null)
                _category = new CategoryRepository(_context);
            return _category;
        }
    }

    public ICartRepository Cart
    {
        get
        {
            if (_cart == null)
                _cart = new CartRepository(_context);
            return _cart;
        }
    }

    public IOrderRepository Order
    {
        get
        {
            if(_order == null)
                _order = new OrderRepository(_context);
            return _order;
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}