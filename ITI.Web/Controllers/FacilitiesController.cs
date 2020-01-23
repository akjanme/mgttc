using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class FacilitiesController : Controller
    {
        // GET: Facilities
        public ActionResult SportsFacilities()
        {
            return View();
        }
        public ActionResult Library()
        {
            return View();
        }
        public ActionResult Laboratory()
        {
            return View();
        }
        public ActionResult ComputerLab()
        {
            return View();
        }
    }
}