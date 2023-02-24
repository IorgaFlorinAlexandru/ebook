namespace Application.DataTransferObjects;

public record AddressDto
{
    public Guid Id { get; set; }
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string? OptionalInfo { get; set; } = null;
    public string ZipCode { get; set; } = string.Empty;
}