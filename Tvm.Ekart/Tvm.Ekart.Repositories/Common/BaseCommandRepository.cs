using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tvm.Ekart.Contracts.Repositories.Common;
using Tvm.Ekart.Data.Contexts;

namespace Tvm.Ekart.Repositories.Common
{
	public class BaseCommandRepository<T> : IBaseCommandRepository<T> where T : class 
	{
		private readonly DbSet<T> _dbSet;
		protected EkartCommandContext Context;

		public BaseCommandRepository(EkartCommandContext context)
		{
			Context = context;
			_dbSet = context.Set<T>();
		}
		public virtual void Add(T entityToInsert)
		{
			_dbSet.Add(entityToInsert);
		}

		public virtual void AddRange(IEnumerable<T> entitiesToInsert)
		{
			_dbSet.AddRange(entitiesToInsert);
		}

		public virtual void Delete(object id)
		{
			var entityToDelete = _dbSet.Find(id);
			Delete(entityToDelete);
		}

		public virtual void Delete(T entityToDelete)
		{
			AttachEntityToDb(entityToDelete);
			_dbSet.Remove(entityToDelete);
		}

		public virtual void Update(T entityToUpdate)
		{
			AttachEntityToDb(entityToUpdate);
			Context.Entry(entityToUpdate).State = EntityState.Modified;
		}

		private bool IsEntityAttachedToDb(T entity)
		{
			return Context.Entry(entity).State != EntityState.Detached;
		}

		private void AttachEntityToDb(T entityToAttach)
		{
			if (!IsEntityAttachedToDb(entityToAttach))
			{
				_dbSet.Attach(entityToAttach);
			}
		}
	}
}
