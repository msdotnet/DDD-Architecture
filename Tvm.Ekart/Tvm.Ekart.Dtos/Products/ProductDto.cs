using System.Collections.Generic;

namespace Tvm.Ekart.Dtos.Products
{
	public class ProductDto
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string SupplierName { get; set; }

        public int? CategoryName { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

    }
}
