using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplicationMenuNow.Models;

namespace MvcApplicationMenuNow.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveToSession(string url, string image, string name)
        {
            Main main = new Main();
            main.url = url;
            main.image = image;
            main.name = name;
            Session["Main"] = main;
            return Json(true);
        }

    }
}
