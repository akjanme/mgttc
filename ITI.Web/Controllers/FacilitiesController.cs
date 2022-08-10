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
        public ActionResult SportsFacilites()
        {
            return View();
        }

        public ActionResult Library()
        {
            return View();
        }

        public ActionResult Laborator()
        {
            return View();
        }

        public ActionResult ComputerLab()
        {
            return View();
        }
    }
}