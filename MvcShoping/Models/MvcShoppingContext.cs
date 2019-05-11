using System.Data.Entity;

namespace MvcShoping.Models
{
    public class MvcShoppingContext : DbContext
    {
        public MvcShoppingContext() : base("name=DefualtConnection")
        { }

        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<OrderHeader> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
    }
}