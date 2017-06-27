using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Tvm.Ekart.Contracts.Repositories.Products;
using Tvm.Ekart.Data.Contexts;
using Tvm.Ekart.Dtos.Products;
using Tvm.Ekart.Entities;
using Tvm.Ekart.Repositories.Common;

namespace Tvm.Ekart.Repositories.Products.Queries
{
	public class ProductQueryRepository : BaseQueryRepository<Product>, IProductQueryRepository
	{
		public ProductQueryRepository(EkartQueryContext context) : base(context)
		{
		}

		public IQueryable<ProductDto> GetProducts()
		{
			return Get(p => p.IsActive).Select(p => new ProductDto
			{
				ProductId = p.ProductId,
				ProductName = p.ProductName,
				QuantityPerUnit = p.QuantityPerUnit,
				UnitPrice = p.UnitPrice,
				UnitsInStock = p.UnitsInStock,
				CategoryName = p.Category.CategoryName,
				SupplierName = p.Supplier.CompanyName
			});
		}

		public async Task<ProductDto> GetProductById(string productId)
		{
			return await GetProducts().FirstOrDefaultAsync(p => p.ProductId == productId);
		}
	}
}