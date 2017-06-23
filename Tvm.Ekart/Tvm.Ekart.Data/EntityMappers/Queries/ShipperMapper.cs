using System.Data.Entity.ModelConfiguration;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.EntityMappers.Queries
{
	internal class ShipperConfiguration : EntityTypeConfiguration<Shipper>
	{
		internal ShipperConfiguration()
		{
			HasMany(e => e.Orders)
				.WithOptional(e => e.Shipper)
				.HasForeignKey(e => e.ShipVia);
		}
	}
}