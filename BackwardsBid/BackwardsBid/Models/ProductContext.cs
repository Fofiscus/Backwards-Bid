using System;
using System.Data.Entity;

namespace BackwardsBid.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("BackwardsBid")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}