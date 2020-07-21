using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopDienThoai.BAL;
using ShopDienThoai.BAL.Interface;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;

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
        public IEnumerable<Brand> Get()
        {
            return brandService.Get();
        }
        [HttpGet]
        [Route("api/brands/get/{id}")]
        public Brand Get(int id)
        {
            return brandService.Get(id);
        }
        [HttpPut]
        [Route("api/brands/editbrand")]
        public int EditBrand(Brand brand)
        {
            return brandService.EditBrand(brand);
        }
        [HttpPost]
        [Route("api/brands/createbrand")]
        public int CreateBrand(BrandViewModel model)
        {
            return brandService.CreateBrand(model);
        }
        [HttpDelete]
        [Route("api/brands/removebrand/{id}")]
        public bool RemoveBrand(int id)
        {
            return brandService.RemoveBrand(id);
        }
    }
}
