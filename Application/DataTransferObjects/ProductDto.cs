namespace Application.DataTransferObjects;

public record ProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    // public List<string> ImageUrls { get; set; } = null!;
    public CategoryDto Category { get; set; } = null!;
}