using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dal;

namespace WebApplication1.Controllers
{
    public class OrderController1 : Controller
    {
        OrderDal od = new OrderDal();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Show()
        {
            return View(od.ShowOrder());
        }
    }
}
