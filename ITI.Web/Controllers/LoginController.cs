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
        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                ITIDataEntities iTIDataEntities = new ITIDataEntities();
                var user = iTIDataEntities.Logins.Where(x => x.user_name == loginModel.User_Name && x.password == loginModel.Password);
                if(user != null)
                {
                    Session["UserName"] = user.FirstOrDefault().user_name; 
                    return Redirect("/Admin/Manage/Index");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");
                }
            }
            return View(loginModel);
        }
        public ActionResult LogOut()
        {
            HttpContext.Session["UserName"] = null;
            Session.Abandon();
            return Redirect("~/Home/Defult");
        }
    }
}