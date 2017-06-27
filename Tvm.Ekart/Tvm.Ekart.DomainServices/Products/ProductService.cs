using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Tvm.Ekart.Contracts.DomainServices;
using Tvm.Ekart.Contracts.UnitOfWork;
using Tvm.Ekart.Entities;
using Tvm.Ekart.Models.Products;

namespace Tvm.Ekart.DomainServices.Products
{
	public class ProductService : IProductService
	{
		private readonly ICommandUnitOfWork _commandUnitOfWork;
		public ProductService(ICommandUnitOfWork commandUnitOfWork)
		{
			_commandUnitOfWork = commandUnitOfWork;
			Mapper.Initialize(cfg => cfg.CreateMap<ProductModel, Product>());
		}

		public async Task<Product> AddProduct(ProductModel productModel)
		{
			if (productModel == null)
			{
				throw new Exception("Can't add empty product model");
			}
			var product = Mapper.Map<Product>(productModel);
			product.ProductId = Guid.NewGuid().ToString();
			_commandUnitOfWork.ProductCommandRepository.Add(product);
			await _commandUnitOfWork.SaveAsync();
			return product;
		}
	}
}
 