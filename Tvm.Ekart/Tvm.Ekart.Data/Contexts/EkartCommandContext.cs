using System.Data.Entity;
using Tvm.Ekart.Data.EntityMappers.Commands;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.Contexts
{
	public class EkartCommandContext : DbContext
	{
		public EkartCommandContext()
			: base("name=EkartContext")
		{
		}

		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<OrderDetail> OrderDetails { get; set; }
		public virtual DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new OrderConfiguration());

			modelBuilder.Configurations.Add(new OrderDetailConfiguration());

			modelBuilder.Configurations.Add(new ProductConfiguration());
		}
	}
}