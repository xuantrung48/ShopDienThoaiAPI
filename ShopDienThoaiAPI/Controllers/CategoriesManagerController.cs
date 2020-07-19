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
    public class CategoriesManagerController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoriesManagerController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        [Route("api/categoriesmanager/get")]
        public IEnumerable<Category> Get()
        {
            return categoryService.Get();
        }
        [Route("api/categoriesmanager/get/{id}")]
        public Category Get(int id)
        {
            return categoryService.Get(id);
        }
        [HttpPut]
        [Route("api/categoriesmanager/editcategory")]
        public int EditCategory([FromBody] Category category)
        {
            return categoryService.EditCategory(category);
        }
        [HttpPost]
        [Route("api/categoriesmanager/createcategory")]
        public int CreateCategory([FromBody] CategoryViewModel model)
        {
            return categoryService.CreateCategory(model);
        }
        [HttpDelete]
        [Route("api/categoriesmanager/removecategory/{id}")]
        public bool RemoveCategory(int id)
        {
            return categoryService.RemoveCategory(id);
        }
    }
}