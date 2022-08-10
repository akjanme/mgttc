using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Web.Data;
using ITI.Models;

namespace ITI.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public ActionResult Home()
        {
            List<NewsTableModel> model = new List<NewsTableModel>();
            return View(model);
        }
    }
}