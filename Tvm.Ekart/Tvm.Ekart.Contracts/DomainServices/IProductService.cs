using System.Threading.Tasks;
using Tvm.Ekart.Entities;
using Tvm.Ekart.Models.Products;

namespace Tvm.Ekart.Contracts.DomainServices
{
	public interface IProductService
	{
		Task<Product> AddProduct(ProductModel productModel);
	}
}