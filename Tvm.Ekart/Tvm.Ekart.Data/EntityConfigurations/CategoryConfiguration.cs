using System.Data.Entity.ModelConfiguration;
using Tvm.Ekart.Entities;

namespace Tvm.Ekart.Data.EntityConfigurations
{
    internal class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        internal CategoryConfiguration()
        {
            ToTable("Category");

            Property(e => e.CategoryName)
                .IsRequired().HasMaxLength(15);

            Property(e => e.Description)
                .HasColumnType("ntext");

            Property(e => e.Picture)
                .HasColumnType("image");
        }
    }
}
