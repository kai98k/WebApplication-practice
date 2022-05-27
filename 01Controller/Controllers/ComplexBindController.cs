using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _01Controller.Models;
//引入命名空間

namespace _01Controller.Controllers
{
    public class ComplexBindController : Controller
    {
        // GET: ComplexBind
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            ViewBag.PId = p.PId;
            ViewBag.PName = p.PName;
            ViewBag.Price = p.Price;
            return View();
        }
    }
}