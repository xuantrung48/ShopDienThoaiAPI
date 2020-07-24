using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.BAL.Interface;
using ShopDienThoai.Domain.Response;
using System.Threading.Tasks;

namespace ShopDienThoai.API.Controllers
{
    [ApiController]
    public class ProductsListController : ControllerBase
    {
        private readonly IProductsListService productsManagerService;
        public ProductsListController(IProductsListService productsManagerService)
        {
            this.productsManagerService = productsManagerService;
        }

        [HttpGet]
        [Route("api/productslist/get")]
        public async Task<ProductsList> Get()
        {
            return await productsManagerService.Get();
        }
    }
}