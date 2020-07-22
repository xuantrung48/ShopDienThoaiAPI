using Microsoft.AspNetCore.Mvc;

namespace ShopDienThoai.Web.Controllers
{
    public class BrandsManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult get(int id)
        {
            var result = new department();
            result = apihelper<department>.httpgetasync(
                                                    $"{helper.apiurl}api/department/get/{id}"
                                                );
            return json(new { result });
        }
    }
}