using ITI.Web.Data; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Models;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    
    public class ManageController : Controller
    {
        public ActionResult admin()
        {
            return View();
        }
    }
}