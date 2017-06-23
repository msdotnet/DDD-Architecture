using System.Data.Entity.ModelConfiguration;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.EntityMappers.Queries
{
	internal class OrderConfiguration : EntityTypeConfiguration<Order>
	{
		internal OrderConfiguration()
		{
			HasMany(e => e.OrderDetails)
				.WithRequired(e => e.Order);
		}
	}
}