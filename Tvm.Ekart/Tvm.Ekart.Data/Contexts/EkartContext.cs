namespace Tvm.Ekart.Data.Contexts
{
    using EntityConfigurations;
    using System.Data.Entity;
    using Tvm.Ekart.Entities;

    public partial class EkartContext : DbContext
    {
        public EkartContext()
            : base("name=EkartContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());

            modelBuilder.Configurations.Add(new OrderConfiguration());

            modelBuilder.Configurations.Add(new OrderDetailConfiguration());

            modelBuilder.Configurations.Add(new ProductConfiguration());

            modelBuilder.Configurations.Add(new ShipperConfiguration());
        }
    }
}
