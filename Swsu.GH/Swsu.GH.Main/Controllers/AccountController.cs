using Swsu.GH.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Swsu.GH.Main.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            List<string> rolesList = new List<string>()
            {
                "Больница",
                "Доктор"
            };
            SelectList roles = new SelectList(rolesList, "Role");

            ViewBag.Roles = roles;

            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Account account)
        {
            var db = new DHContext();

            string isCorrect = String.Empty;

            switch (account.Role)
            {
                case "Больница":
                    isCorrect = db.Hospitals
                        .Where(u => u.Name == account.UserName)
                        .Select(u => u.Name)
                        .SingleOrDefault();
                    break;
                case "Доктор":
                    isCorrect = db.Doctors
                        .Where(u => u.Username == account.UserName)
                        .Where(u => u.Password == account.Password)
                        .Select(u => u.Name)
                        .SingleOrDefault();
                    break;
            }

            if (String.IsNullOrEmpty(isCorrect))
            {
                Session["isAuth"] = true;
                return Redirect("~/Home/Cabinet");
            }

            return Redirect("~/Error/LogInError");
        }
    }
}