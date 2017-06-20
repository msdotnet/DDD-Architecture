using System.Data.Entity.ModelConfiguration;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.EntityConfigurations
{
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        internal CustomerConfiguration()
        {
            ToTable("Customer");

            Property(e => e.CustomerId)
                .IsFixedLength()
                .HasMaxLength(5);

            Property(e => e.ContactName)
                .HasMaxLength(30);

            Property(e => e.ContactTitle)
                .HasMaxLength(30);

            Property(e => e.Address)
                .HasMaxLength(60);

            Property(e => e.City)
                .HasMaxLength(15);

            Property(e => e.PostalCode)
                .HasMaxLength(10);

            Property(e => e.Phone)
                .HasMaxLength(24);
        }

    }
}
