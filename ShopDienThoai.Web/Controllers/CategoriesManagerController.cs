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
            List<Category> result = ApiHelper<List<Category>>.HttpGetAsync($"{Helper.ApiUrl}api/categories/get");
            return Json(new { result });
        }

        public JsonResult Get(int id)
        {
            Category result = ApiHelper<Category>.HttpGetAsync($"{Helper.ApiUrl}api/categories/get/{id}");
            return Json(new { result });
        }

        public JsonResult Delete(int id)
        {
            ActionCategoryResult result = ApiHelper<ActionCategoryResult>.HttpGetAsync($"{Helper.ApiUrl}api/categories/delete/{id}", "DELETE");
            return Json(new { result });
        }
        public JsonResult Save([FromBody] Category model)
        {
            ActionCategoryResult result;
            if (model.Name == "")
                result = new ActionCategoryResult()
                {
                    Message = "Nhập vào tên danh mục!"
                };
            else
                result = ApiHelper<ActionCategoryResult>.HttpPostAsync($"{Helper.ApiUrl}api/categories/save", model);
            return Json(new { result });
        }
    }
}