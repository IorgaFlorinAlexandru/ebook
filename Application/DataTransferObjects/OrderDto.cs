using Domain.Enums;

namespace Application.DataTransferObjects;

public record OrderDto
{
    public Guid Id { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime DeliveredAt { get; set; }
    public OrderStatus Status { get; set; }
    public List<ProductDto> Products { get; set; } = null!;
    public decimal TotalCost { get; set; }
}