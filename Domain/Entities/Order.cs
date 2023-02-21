using Domain.Enums;

namespace Domain.Entities;

public class Order
{
    public Guid Id { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime DeliveredAt { get; set; }
    public OrderStatus Status { get; set; }
    public Guid AddressId { get; set; }
    public Address Address { get; set; } = null!;
    public decimal TotalCost { get; set; }
}