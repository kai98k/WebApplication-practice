using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class HWController : Controller
    {
        public void ValueCounter()
        {
            int a = 42;
            float b = 2.5f;
            Response.Write(a+b);
            Response.Write("<br>");
            Response.Write(a-b);
        }
    }
}