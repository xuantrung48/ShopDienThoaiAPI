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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        [Route("api/categories/get")]
        public IEnumerable<Category> Get()
        {
            return categoryService.Get();
        }
        [HttpGet]
        [Route("api/categories/get/{id}")]
        public Category Get(int id)
        {
            return categoryService.Get(id);
        }
        [HttpPut]
        [Route("api/categories/editcategory")]
        public int EditCategory(Category category)
        {
            return categoryService.EditCategory(category);
        }
        [HttpPost]
        [Route("api/categories/createcategory")]
        public int CreateCategory(CategoryViewModel model)
        {
            return categoryService.CreateCategory(model);
        }
        [HttpDelete]
        [Route("api/categories/removecategory/{id}")]
        public bool RemoveCategory(int id)
        {
            return categoryService.RemoveCategory(id);
        }
    }
}