using Tvm.Ekart.Contracts.Repositories.Products;
using Tvm.Ekart.Data.Contexts;
using Tvm.Ekart.Entities;
using Tvm.Ekart.Repositories.Common;

namespace Tvm.Ekart.Repositories.Products.Commands
{
	public class ProductCommandRepository : BaseCommandRepository<Product>, IProductCommandRepository
	{
		public ProductCommandRepository(EkartCommandContext context) : base(context)
		{
		}
	}
}
