using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using _05CustomValidator.Models;

namespace _05CustomValidator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Create(string success)
        {
            TempData["success"] = "";
            return View();
        }

        [HttpPost]
        public ActionResult Create(Member member)
        {
            TempData["success"] = "";
            if (ModelState.IsValid)
            {
                TempData["success"] = "成功";
                //dbsave
                return View();
            }
            return View();
        }

    }
}