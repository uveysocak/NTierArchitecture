using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models;

public class OrderDetail : Entity
{
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public Product? Product { get; set; }
    public Order? Order { get; set; }
    public Guid ProductId { get; set; }
    public Guid OrderId { get; set; }
}