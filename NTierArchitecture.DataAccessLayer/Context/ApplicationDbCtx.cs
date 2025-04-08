using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Context;
public class ApplicationDbCtx : DbContext
{

    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source = CHABORZ-UVAYS\SQLEXPRESS; Initial Catalog = ETicaret051124; Integrated Security = True;Trust Server Certificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {//OrderDetail tablosunun Id alanı iptal edildi
        modelBuilder.Entity<OrderDetail>().Ignore(x => x.Id);
        modelBuilder.Entity<OrderDetail>().HasKey(o => new { o.OrderId, o.ProductId });
    }

}
