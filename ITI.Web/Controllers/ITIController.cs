using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class ITIController : Controller
    {
        // GET: ITI
        public ActionResult StateDirectorate()
        {
            return View();
        }
        public ActionResult RightToInformation()
        {
            return View();
        }
        public ActionResult Certifications()
        {
            return View();
        }
        public ActionResult InstituteManagement()
        {
            return View();
        }
    }
}