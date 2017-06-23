using System.Data.Entity.ModelConfiguration;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.EntityMappers.Queries
{
	internal class ProductConfiguration : EntityTypeConfiguration<Product>
	{
		internal ProductConfiguration()
		{
			HasMany(e => e.OrderDetails)
				.WithRequired(e => e.Product)
				.WillCascadeOnDelete(false);
		}
	}
}