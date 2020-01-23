using ITI.Models;
using ITI.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class HomeController : Controller
    { 
        public ActionResult Defult()
        { 
            return View();
        }
    }
}