using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.BAL.Interface;
using ShopDienThoai.Domain.Request.Products;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.API.Controllers
{
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [Route("api/products/get")]
        public async Task<IEnumerable<Product>> Get()
        {
            return await productService.Get();
        }
        [HttpGet]
        [Route("api/products/get/{id}")]
        public async Task<Product> Get(string id)
        {
            return await productService.Get(id);
        }
        [HttpPost]
        [Route("api/products/save")]
        public async Task<ActionProductResult> Save(CreateProductRequest product)
        {
            return await productService.Save(product);
        }
        [HttpDelete]
        [Route("api/products/delete/{id}")]
        public async Task<ActionProductResult> Remove(string id)
        {
            return await productService.Delete(id);
        }
    }
}