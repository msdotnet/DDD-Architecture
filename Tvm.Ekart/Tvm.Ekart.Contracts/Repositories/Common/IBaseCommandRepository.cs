using System.Collections.Generic;

namespace Tvm.Ekart.Contracts.Repositories.Common
{
	public interface IBaseCommandRepository<T>
	{
		void Add(T entityToInsert);
		void AddRange(IEnumerable<T> entitiesToInsert);
		void Delete(object id);
		void Delete(T entityToDelete);
		void Update(T entityToUpdate);
	}
}