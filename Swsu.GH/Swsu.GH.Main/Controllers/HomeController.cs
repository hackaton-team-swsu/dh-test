using Swsu.GH.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Swsu.GH.Main.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["isAuth"] == null)
            {
                Session["isAuth"] = false;
            }
            return View();
        }

        public ActionResult Cabinet()
        {
            if (!(bool)Session["isAuth"])
            {
                return Redirect("~/Account/Index");
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}