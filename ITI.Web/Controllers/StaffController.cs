using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Data;
using ITI.Repository.Repository;
using ITI.Models;

namespace ITI.Web.Controllers
{
    public class StaffController : Controller
    {
        private readonly StaffRepository staffRepository; 
        public StaffController()
        {
            staffRepository = new StaffRepository(); 

        }
        public ActionResult AcademicStaff()
        {
            var staffacademic = staffRepository.GetStaff();
            return View(staffacademic);
        }
        
        public ActionResult TechnicalStaff()
        {
            var staffTechnicals = staffRepository.GetStaff();
            return View(staffTechnicals);
        }
    }
}