using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Web.Data;
using ITI.Models; 


namespace ITI.Web.Controllers
{
    public class StaffStudentController : Controller
    {
        MgttcEntities mgttcEntities;
        public StaffStudentController()
        {
            mgttcEntities = new MgttcEntities();
        }

        public ActionResult Staff()
        {  
            List<Staff> staffTechnicals = mgttcEntities.Staffs.Where((Staff x) => x.StaffType == "B_Ed").ToList();
            return View(staffTechnicals);
        }

        public ActionResult Staffd()
        {
            List<Staff> staffTechnicals = mgttcEntities.Staffs.Where((Staff x) => x.StaffType == "D_El_Ed").ToList(); 
            return View("Staff", staffTechnicals);
        }

        public ActionResult StaffI()
        {
            List<Staff> staffTechnicals = mgttcEntities.Staffs.Where((Staff x) => x.StaffType == "INTEGRATED").ToList(); 
            return View("Staff", staffTechnicals);
        }

        public ActionResult StudentList()
        {
            List<Student> studendtList = mgttcEntities.Students.ToList(); 
            return View(studendtList);
        }

        public ActionResult FacultyOfEdcation()
        {
            return View();
        }

        public ActionResult StudentCategoryWise()
        {
            return View();
        }

        public ActionResult Course()
        {
            return View();
        }
    }
}