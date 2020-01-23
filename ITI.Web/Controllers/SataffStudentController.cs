using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class SataffStudentController : Controller
    {
        // GET: SataffStudent
        public ActionResult Staff()
        {
            return View();
        }
        public ActionResult NonTeachingStaff()
        {
            return View();
        }
        public ActionResult StudentList()
        {
            return View();
        }
        public ActionResult FacultyOfEducation()
        {
            return View();
        }
        public ActionResult StudentCategory()
        {
            return View();
        }
        public ActionResult Course()
        {
            return View();
        }
    }
}