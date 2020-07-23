using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Domain.Response;
using ShopDienThoai.Web.Ultilities;
using System.Collections.Generic;

namespace ShopDienThoai.Web.Controllers
{
    public class CategoriesManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            List<Category> categories = ApiHelper<List<Category>>.HttpGetAsync($"{Helper.ApiUrl}api/categories/get");
            return Json(new { categories });
        }

        public JsonResult Get(int id)
        {
            Category category = ApiHelper<Category>.HttpGetAsync($"{Helper.ApiUrl}api/categories/get/{id}");
            return Json(new { category });
        }

        public JsonResult Delete(int id)
        {
            ActionCategoryResult result = ApiHelper<ActionCategoryResult>.HttpGetAsync($"{Helper.ApiUrl}api/categories/delete/{id}", "DELETE");
            return Json(new { result });
        }
        public JsonResult Save([FromBody] Category model)
        {
            ActionCategoryResult result = ApiHelper<ActionCategoryResult>.HttpPostAsync($"{Helper.ApiUrl}api/categories/save", model);
            return Json(new { result });
        }
    }
}