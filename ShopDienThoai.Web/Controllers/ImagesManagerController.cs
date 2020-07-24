using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Domain.Response;
using ShopDienThoai.Web.Ultilities;

namespace ShopDienThoai.Web.Controllers
{
    public class ImagesManagerController : Controller
    {
        public JsonResult Gets()
        {
            List<Image> result = ApiHelper<List<Image>>.HttpGetAsync($"{Helper.ApiUrl}api/images/get");
            return Json(new { result });
        }

        public JsonResult Get(int id)
        {
            Image result = ApiHelper<Image>.HttpGetAsync($"{Helper.ApiUrl}api/images/get/{id}");
            return Json(new { result });
        }

        public JsonResult GetImagesByProductId(string id)
        {
            List<Image> result = ApiHelper<List<Image>>.HttpGetAsync($"{Helper.ApiUrl}api/images/getimagesbyproductid/{id}");
            return Json(new { result });
        }
        public JsonResult Delete(int id)
        {
            ActionImageResult result = ApiHelper<ActionImageResult>.HttpGetAsync($"{Helper.ApiUrl}api/images/delete/{id}", "DELETE");
            return Json(new { result });
        }
        public JsonResult Save([FromBody] Image model)
        {
            var result = ApiHelper<ActionImageResult>.HttpPostAsync($"{Helper.ApiUrl}api/images/save", model);
            return Json(new { result });
        }
    }
}