using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models;

public class Product : Entity
{
    public string? ProductName { get; set; }
    public double UnitPrice { get; set; }
    public bool Discontinued { get; set; }
    public int UnitsInStock { get; set; }
    public Guid CategoryId { get; set; }
    public Guid SupplierId { get; set; }
    public Category? Category { get; set; }
    public Supplier? Supplier { get; set; }
    public ICollection<OrderDetail>? OrderDetails { get; set; }

}
