using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class OrderItem
{
    [Key]
    [Column(Order = 1)]
    public Guid OrderId { get; set; }
    public Order Order { get; set; } = null!;
    
    [Key]
    [Column(Order = 2)]
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int Quantity { get; set; }
}