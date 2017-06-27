using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Tvm.Ekart.Contracts.DomainServices;
using Tvm.Ekart.Contracts.UnitOfWork;
using Tvm.Ekart.Models.Products;

namespace Tvm.Ekart.Api.Controllers.Products
{
    public class ProductsController : ApiController
    {
	    private readonly IQueryUnitOfWork _queryUnitOfWork;
	    private readonly IProductService _productService;
	    public ProductsController(IQueryUnitOfWork queryUnitOfWork, IProductService productService)
	    {
		    _queryUnitOfWork = queryUnitOfWork;
		    _productService = productService;
	    }

	    public IHttpActionResult GetProducts()
	    {
		    var products = _queryUnitOfWork.ProductQueryRepository.GetProducts();
		    return Ok(products);
	    }

	    public IHttpActionResult GetProduct(string id)
	    {
		    var product = _queryUnitOfWork.ProductQueryRepository.GetProductById(id);
		    return Ok(product);
	    }

	    public async Task<IHttpActionResult> AddProduct(ProductModel productModel)
	    {
		    await _productService.AddProduct(productModel);
		    return Ok();
	    }
    }
}
