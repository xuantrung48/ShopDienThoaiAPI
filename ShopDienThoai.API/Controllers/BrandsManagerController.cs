﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopDienThoai.BAL;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;

namespace ShopDienThoai.API.Controllers
{
    [ApiController]
    public class BrandsManagerController : ControllerBase
    {
        private readonly BrandService brandService;
        public BrandsManagerController(BrandService brandService)
        {
            this.brandService = brandService;
        }
        private readonly ILogger<BrandsManagerController> _logger;

        public BrandsManagerController(ILogger<BrandsManagerController> logger, BrandService brandService)
        {
            _logger = logger;
            this.brandService = brandService;
        }

        [HttpGet]
        [Route("[api/brandsmanager/get]")]
        public IEnumerable<Brand> Get()
        {
            return brandService.Get();
        }
        [Route("[api/brandsmanager/get/{id}]")]
        public Brand Get(int id)
        {
            return brandService.Get(id);
        }
        [HttpPut]
        [Route("[api/brandsmanager/editbrand]")]
        public int EditBrand([FromBody] Brand brand)
        {
            return brandService.EditBrand(brand);
        }
        [HttpPost]
        [Route("[api/brandsmanager/createbrand]")]
        public int CreateBrand([FromBody] BrandViewModel model)
        {
            return brandService.CreateBrand(model);
        }
        [HttpDelete]
        [Route("[api/brandsmanager/removebrand/{id}]")]
        public bool RemoveBrand(int id)
        {
            return brandService.RemoveBrand(id);
        }
    }
}