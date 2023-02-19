namespace Application.DataTransferObjects;

public record CartItemDto
{
    public ProductDto Product { get; set; } = null!;
    public int Quantity { get; set; }
}