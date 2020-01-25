using ITI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Data;
using ITI.Repository;

namespace ITI.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                MGTTCEntities mGTTCEntities = new MGTTCEntities();
                var user = mGTTCEntities.Logins.Where(x => x.user_name == login.user_name && x.password == login.password);
                if(user != null)
                {
                    Session["UserName"] = user.FirstOrDefault().user_name; 
                    return Redirect("/Admin/Manage/Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");
                }
            }
            return View(login);
        }
        public ActionResult LogOut()
        {
            HttpContext.Session["UserName"] = null;
            Session.Abandon();
            return Redirect("~/Home/Defult");
        }
    }
}