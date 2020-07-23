using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.BAL.Interface;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.API.Controllers
{
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService brandService;
        public BrandsController(IBrandService brandService)
        {
            this.brandService = brandService;
        }

        [HttpGet]
        [Route("api/brands/get")]
        public async Task<IEnumerable<Brand>> Get()
        {
            return await brandService.Get();
        }
        [HttpGet]
        [Route("api/brands/get/{id}")]
        public async Task<Brand> Get(int id)
        {
            return await brandService.Get(id);
        }
        [HttpPost]
        [Route("api/brands/save")]
        public async Task<ActionBrandResult> Save(Brand brand)
        {
            return await brandService.Save(brand);
        }
        [HttpDelete]
        [Route("api/brands/delete/{id}")]
        public async Task<ActionBrandResult> Remove(int id)
        {
            return await brandService.Delete(id);
        }
    }
}
