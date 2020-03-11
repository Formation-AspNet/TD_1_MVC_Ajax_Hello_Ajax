using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello_Ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {

            return View();
        }

        public ActionResult Somme(float x, float y)
        {
            float z = x + y;
            ViewBag.result = z;
            return View();
        }
    }
}