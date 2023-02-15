using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence;

namespace Infrastructure.Repository;

public class CartRepository : RepositoryBase<Cart>, ICartRepository
{
    public CartRepository(ApplicationDbContext context)
         : base(context)
    {
    }
}