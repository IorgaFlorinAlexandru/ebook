namespace Application.DataTransferObjects;

public record ProductDto
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public CategoryDto Category { get; set; } = null!;
}