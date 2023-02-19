namespace Domain.Repositories;

public interface IRepositoryWrapper
{
    IProductRepository Product { get; }
    ICategoryRepository Category { get; }
    ICartRepository Cart { get; }
    IOrderRepository Order { get; }
    void Save();
    Task SaveAsync();
}