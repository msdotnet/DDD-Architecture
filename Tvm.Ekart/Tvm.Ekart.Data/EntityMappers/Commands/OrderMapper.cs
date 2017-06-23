using System.Data.Entity.ModelConfiguration;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.EntityMappers.Commands
{
	internal class OrderConfiguration : EntityTypeConfiguration<Order>
	{
		internal OrderConfiguration()
		{
			ToTable("Order");

			Property(e => e.CustomerId)
				.IsFixedLength()
				.HasMaxLength(5);

			Property(e => e.ShipName)
				.HasMaxLength(40);

			Property(e => e.ShipAddress)
				.HasMaxLength(60);

			Property(e => e.ShipCity)
				.HasMaxLength(15);

			Property(e => e.ShipPostalCode)
				.HasMaxLength(10);

			HasMany(e => e.OrderDetails)
				.WithRequired(e => e.Order)
				.WillCascadeOnDelete(false);
		}
	}
}