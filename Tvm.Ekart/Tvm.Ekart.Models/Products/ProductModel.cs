using System.Collections.Generic;

namespace Tvm.Ekart.Models.Products
{
	public partial class ProductModel
    {
        public string ProductName { get; set; }

        public int? SupplierId { get; set; }

        public int? CategoryId { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

	    public bool	IsActive { get; set; }

    }
}
