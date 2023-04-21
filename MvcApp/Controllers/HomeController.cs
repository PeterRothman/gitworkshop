using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Superman is the coolest super hero!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Super man street 1, 123456 New York";

            return View();
        }
    }
}