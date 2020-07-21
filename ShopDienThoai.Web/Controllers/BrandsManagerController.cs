using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopDienThoai.Web.Controllers
{
    public class BrandsManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}