using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Domain.Response;
using ShopDienThoai.Web.Ultilities;
using System.Collections.Generic;

namespace ShopDienThoai.Web.Controllers
{
    public class BrandsManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            List<Brand> brands = ApiHelper<List<Brand>>.HttpGetAsync($"{Helper.ApiUrl}api/brands/get");
            return Json(new { brands });
        }

        public JsonResult Get(int id)
        {
            Brand brand = ApiHelper<Brand>.HttpGetAsync($"{Helper.ApiUrl}api/brands/get/{id}");
            return Json(new { brand });
        }

        public JsonResult Delete(int id)
        {
            ActionBrandResult result = ApiHelper<ActionBrandResult>.HttpGetAsync($"{Helper.ApiUrl}api/brands/delete/{id}", "DELETE");
            return Json(new { result });
        }
        public JsonResult Save([FromBody] Brand model)
        {
            ActionBrandResult result = ApiHelper<ActionBrandResult>.HttpPostAsync($"{Helper.ApiUrl}api/brands/save", model);
            return Json(new { result });
        }
    }
}