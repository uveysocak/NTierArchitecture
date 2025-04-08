using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models;
public class Category : Entity
{
    public string? CategoryName { get; set; }
    public string? Description { get; set; }
    public ICollection<Product>? Products { get; set; }

}
