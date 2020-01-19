using ITI.Models;
using ITI.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsRepository newsRepository;
        private readonly InstituteRepository instituteRepository;
        public HomeController()
        {
            instituteRepository = new InstituteRepository();
            newsRepository = new NewsRepository();
        } 

        public ActionResult Mission()
        {
            return View();
        }

        public ActionResult Aboutus()
        {
            return View();
        }
        public ActionResult Institute()
        {
            InstituteDetailModel instituteDetailModel = new InstituteDetailModel();
            var model = instituteRepository.GetInstitute().FirstOrDefault();
            if(model!=null)
            {
                instituteDetailModel.ID = model.ID;
                instituteDetailModel.Name = model.Name;
                instituteDetailModel.RegNo = model.RegNo;
                instituteDetailModel.CertficateLink = model.CertficateLink; 
            }
            return View(instituteDetailModel);
        }
        public ActionResult Home()
        {
            var nws = newsRepository.GetNews().Select(x => new NewsTableModel { ID = x.ID, NewsText = x.NewsText, NewsDate = x.NewsDate, NewsHeadLine = x.NewsHeadLine });
            return View(nws);
        }
        public ActionResult Defult()
        {
            var nws = newsRepository.GetNews().Select(x => new NewsTableModel { ID = x.ID, NewsText=x.NewsText, NewsDate=x.NewsDate, NewsHeadLine=x.NewsHeadLine });
            return View(nws);
        }
    }
}