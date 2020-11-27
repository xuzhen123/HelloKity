using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace K8s.Test1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("这是K8s test3  第三次测试。");
        }
    }
}