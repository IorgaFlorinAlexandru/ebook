namespace Domain.Entities;

public class Cart
{
    public Guid Id { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
}