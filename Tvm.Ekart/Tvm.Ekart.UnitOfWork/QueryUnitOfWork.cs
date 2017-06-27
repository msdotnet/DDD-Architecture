using System.Threading.Tasks;
using Tvm.Ekart.Contracts.Repositories.Products;
using Tvm.Ekart.Contracts.UnitOfWork;
using Tvm.Ekart.Data.Contexts;
using Tvm.Ekart.Repositories.Products.Queries;

namespace Tvm.Ekart.UnitOfWork
{
    public class QueryUnitOfWork : IQueryUnitOfWork
    {
	    public IProductQueryRepository ProductQueryRepository { get; set; }

		public QueryUnitOfWork(EkartQueryContext context)
        {
			ProductQueryRepository = new ProductQueryRepository(context);
        }
    }
}
