using System.Linq;
using System.Threading.Tasks;
using Tvm.Ekart.Dtos.Products;

namespace Tvm.Ekart.Contracts.Repositories.Products
{
	public interface IProductQueryRepository
	{
		IQueryable<ProductDto> GetProducts();
		Task<ProductDto> GetProductById(string productId);
	}
}