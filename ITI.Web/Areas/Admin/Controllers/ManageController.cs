using ITI.Repository.Repository;
using ITI.Data; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Models;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class ManageController : Controller
    {
        // GET: Admin/Manage 
        //public ActionResult AddReportCard()
        //{
        //    ViewBag.Category = StaticData.GetCategories();
        //    ViewBag.Trade = StaticData.GetTrade();
        //    ViewBag.Unit = StaticData.GetUnit();
        //    ViewBag.Session = StaticData.GetSession();
        //    return View();
        //} 
        
        //public ActionResult DelectReportCard()
        //{
        //    ViewBag.Category = StaticData.GetCategories();
        //    ViewBag.Trade = StaticData.GetTrade();
        //    ViewBag.Unit = StaticData.GetUnit();
        //    ViewBag.Session = StaticData.GetSession();
        //    return View();
        //} 
        public ActionResult Index()
        {
            return View();
        }
    }
}