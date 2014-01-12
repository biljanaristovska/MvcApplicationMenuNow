using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplicationMenuNow.Models;

namespace MvcApplicationMenuNow.Controllers
{
    public class ListsController : Controller
    {
        //
        // GET: /Lists/

        public ActionResult Index()
        {
            Main main = (Main)(Session["Main"]);
            if (main == null)
            { //ова е моментот кога нема модел во сесијата, т.е кога се отвора дирекно view-то Lists, за да не може да се оствори дирекно
                main = new Main();
                main.url = "http://rmservice-bb.apphb.com";
            }

            if (main.url == null)
            {
                return Redirect("Home");
            }

            return View(main);
        }

    }
}
