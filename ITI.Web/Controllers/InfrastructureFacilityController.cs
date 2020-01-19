using ITI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class InfrastructureFacilityController : Controller
    {
        private ITIDataEntities db;
        public InfrastructureFacilityController()
        {
            db = new ITIDataEntities();
        }
        // GET: InfrastructureFacility
        public ActionResult InfrastructureBuiliding()
        {
           
            return View();
        }
        public ActionResult PowerSupply()
        {
            return View();
        }
        public ActionResult MedicalFacilities()
        {
            return View();
        }
        public ActionResult ToolEquipments()
        {
            return View();
        }
    }
}