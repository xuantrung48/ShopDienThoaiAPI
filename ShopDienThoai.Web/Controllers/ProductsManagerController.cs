using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Domain.Request.Products;
using ShopDienThoai.Domain.Response;
using ShopDienThoai.Web.Ultilities;
using System;
using System.Collections.Generic;

namespace ShopDienThoai.Web.Controllers
{
    public class ProductsManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            ProductsList result = ApiHelper<ProductsList>.HttpGetAsync($"{Helper.ApiUrl}api/productslist/get");
            return Json(new { result });
        }

        public JsonResult Get(string id)
        {
            Product result = ApiHelper<Product>.HttpGetAsync($"{Helper.ApiUrl}api/products/get/{id}");
            return Json(new { result });
        }

        public JsonResult Delete(string id)
        {
            ActionProductResult result = ApiHelper<ActionProductResult>.HttpGetAsync($"{Helper.ApiUrl}api/products/delete/{id}", "DELETE");
            return Json(new { result });
        }
        public JsonResult Save([FromBody] CreateProductRequest model)
        {
            var result = ApiHelper<ActionProductResult>.HttpPostAsync($"{Helper.ApiUrl}api/products/save", model);
            return Json(new { result });
        }
    }
}