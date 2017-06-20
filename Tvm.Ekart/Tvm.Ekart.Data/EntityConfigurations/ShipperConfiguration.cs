using System.Data.Entity.ModelConfiguration;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.EntityConfigurations
{
    internal class ShipperConfiguration : EntityTypeConfiguration<Shipper>
    {
        internal ShipperConfiguration()
        {
            ToTable("Shipper");

            Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            Property(e => e.Phone)
                .HasMaxLength(24);

            HasMany(e => e.Orders)
                .WithOptional(e => e.Shipper)
                .HasForeignKey(e => e.ShipVia);

        }
    }
}
