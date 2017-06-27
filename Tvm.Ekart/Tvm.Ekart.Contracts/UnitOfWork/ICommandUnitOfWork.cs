using System.Threading.Tasks;
using Tvm.Ekart.Contracts.Repositories.Products;

namespace Tvm.Ekart.Contracts.UnitOfWork
{
	public interface ICommandUnitOfWork
	{
		IProductCommandRepository ProductCommandRepository { get; set; }
		void Save();
		Task SaveAsync();
	}
}