using Tvm.Ekart.Contracts.Repositories.Products;

namespace Tvm.Ekart.Contracts.UnitOfWork
{
	public interface IQueryUnitOfWork
	{
		IProductQueryRepository ProductQueryRepository { get; set; }
	}
}