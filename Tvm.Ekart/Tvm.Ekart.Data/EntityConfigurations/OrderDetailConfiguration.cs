using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.EntityConfigurations
{
    internal class OrderDetailConfiguration : EntityTypeConfiguration<OrderDetail>
    {
        internal OrderDetailConfiguration()
        {
            ToTable("OrderDetail");

            HasKey(e => new { e.OrderId, e.ProductId });

            Property(e => e.OrderId)
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(e => e.ProductId)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(e => e.UnitPrice)
                .HasColumnType("money")
                .HasPrecision(19, 4);

        }
    }
}
