using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tvm.Ekart.Contracts.Repositories.Products;
using Tvm.Ekart.Contracts.UnitOfWork;
using Tvm.Ekart.Data.Contexts;
using Tvm.Ekart.Repositories.Products.Commands;

namespace Tvm.Ekart.UnitOfWork
{
	public class CommandUnitOfWork : ICommandUnitOfWork
	{
		private readonly EkartCommandContext _context;
		public IProductCommandRepository ProductCommandRepository{ get; set; }

		public CommandUnitOfWork(EkartCommandContext context)
		{
			_context = context;
			ProductCommandRepository = new ProductCommandRepository(context);
		}
		public void Save()
		{
			_context.SaveChanges();
		}
		public async Task SaveAsync()
		{
			await _context.SaveChangesAsync();
		}
	}
}
