using System;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Tvm.Ekart.Data.EntityMappers.Queries;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.Contexts
{
	public class EkartQueryContext : DbContext
	{
		public EkartQueryContext()
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
			modelBuilder.Entity<Customer>().ToTable("Customer");

			modelBuilder.Configurations.Add(new OrderConfiguration());

			modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail");

			modelBuilder.Configurations.Add(new ProductConfiguration());

			modelBuilder.Configurations.Add(new ShipperConfiguration());
		}

		public override int SaveChanges()
		{
			throw new NotImplementedException();
		}

		public override Task<int> SaveChangesAsync()
		{
			throw new NotImplementedException();
		}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}