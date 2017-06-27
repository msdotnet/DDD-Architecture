using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tvm.Ekart.Contracts.Repositories.Common
{
	public interface IBaseQueryRepository<T>
	{
		IQueryable<T> Get(Expression<Func<T, bool>> filter = null,
			Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
			string includeProperties = "",
			int? page = null,
			int? pageSize = null);

		T GetById(object id);
		IQueryable<T> FindBy(Expression<Func<T, bool>> filter);
		bool Any(Expression<Func<T, bool>> filter);
	}
}
