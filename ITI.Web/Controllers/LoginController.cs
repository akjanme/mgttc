using ITI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Web.Data;

namespace ITI.Web.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (base.ModelState.IsValid)
            {
                Login user = new MgttcEntities().Logins.FirstOrDefault((Login x) => x.user_name == loginModel.User_Name && x.password == loginModel.Password);
                if (user != null)
                {
                    base.Session["UserName"] = user.user_name;
                    return Redirect("/Admin/AdminHome/Index");
                }
                base.ModelState.AddModelError("", "Invalid login credentials.");
            }
            return View(loginModel);
        }

        public ActionResult LogOut()
        {
            base.HttpContext.Session["UserName"] = null;
            base.Session.Abandon();
            return Redirect("~/Default/Index");
        }
    }
}