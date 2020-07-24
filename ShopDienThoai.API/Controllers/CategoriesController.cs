using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.BAL.Interface;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<Category>> Get()
        {
            return await categoryService.Get();
        }
        [HttpGet]
        [Route("api/categories/get/{id}")]
        public async Task<Category> Get(int id)
        {
            return await categoryService.Get(id);
        }
        [HttpPost]
        [Route("api/categories/save")]
        public async Task<ActionCategoryResult> Save(Category category)
        {
            return await categoryService.Save(category);
        }
        [HttpDelete]
        [Route("api/categories/delete/{id}")]
        public async Task<ActionCategoryResult> Remove(int id)
        {
            return await categoryService.Delete(id);
        }
    }
}