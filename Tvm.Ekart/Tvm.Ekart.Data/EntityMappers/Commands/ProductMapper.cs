using System.Data.Entity.ModelConfiguration;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.EntityMappers.Commands
{
	internal class ProductConfiguration : EntityTypeConfiguration<Product>
	{
		internal ProductConfiguration()
		{
			ToTable("Product");

			Property(e => e.ProductName)
				.IsRequired()
				.HasMaxLength(40);

			Property(e => e.QuantityPerUnit)
				.HasMaxLength(20);

			Property(e => e.UnitPrice)
				.HasColumnType("money");

			Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			HasMany(e => e.OrderDetails)
				.WithRequired(e => e.Product)
				.WillCascadeOnDelete(false);
		}
	}
}