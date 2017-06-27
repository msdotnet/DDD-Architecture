using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Tvm.Ekart.Contracts.Repositories.Common;
using Tvm.Ekart.Data.Contexts;

namespace Tvm.Ekart.Repositories.Common
{
	public class BaseQueryRepository<T> : IBaseQueryRepository<T> where T : class
	{
		private readonly DbSet<T> _dbSet;
		protected EkartQueryContext Context;

		protected BaseQueryRepository(EkartQueryContext context)
		{
			context = context;
			_dbSet = context.Set<T>();
		}

		public virtual IQueryable<T> Get(Expression<Func<T, bool>> filter = null,
			Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
			string includeProperties = "",
			int? page = null,
			int? pageSize = null)
		{
			IQueryable<T> query = _dbSet;

			if (filter != null)
			{
				query = query.Where(filter);
			}
			if (filter != null)
			{
				query = includeProperties.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries)
					.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
			}
			if (orderBy != null)
			{
				query = orderBy(query);
			}
			if (page != null && pageSize != null)
				query = query
					.Skip((page.Value - 1)*pageSize.Value)
					.Take(pageSize.Value);

			return query;
		}

		public virtual T GetById(object id)
		{
			return _dbSet.Find(id);
		}

		public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> filter)
		{
			return _dbSet.Where(filter);
		}

		public virtual bool Any(Expression<Func<T, bool>> filter)
		{
			return _dbSet.Any(filter);
		}
	}
}