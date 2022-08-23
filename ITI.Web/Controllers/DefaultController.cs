using ITI.Models;
using ITI.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class DefaultController : Controller
    { 
        protected MgttcEntities mgttcEntities;
        public DefaultController()
        {
            mgttcEntities = new MgttcEntities();
        }

        public ActionResult Index()
        {
            try
            {
                IEnumerable<NewsTableModel> news = from x in mgttcEntities.NewsTables
                                                   select new NewsTableModel
                                                   {
                                                       ID = x.ID,
                                                       NewsDate = x.NewsDate,
                                                       NewsHeadLine = x.NewsHeadLine,
                                                       NewsText=x.NewsText
                                                   };
                return View(news);
            }
            catch(Exception ex)
            {
                return View(new List<NewsTableModel>().AsEnumerable());
            }
        }
    }
}