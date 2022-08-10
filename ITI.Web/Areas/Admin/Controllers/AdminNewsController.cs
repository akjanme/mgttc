using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Web.Data;
using ITI.Models;
using ITI.Web.Filter;
using System.Data.Entity;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class AdminNewsController : Controller
    {
        protected MgttcEntities mgttcEntities;
        public AdminNewsController()
        {
            mgttcEntities = new MgttcEntities();
        }

        public ActionResult Index()
        {
            IEnumerable<NewsTableModel> news = from x in mgttcEntities.NewsTables
                                               select new NewsTableModel
                                               {
                                                   ID = x.ID,
                                                   NewsDate = x.NewsDate,
                                                   NewsHeadLine = x.NewsHeadLine
                                               };
            return View(news);
        }

        public ActionResult Create(int id = 0)
        {
            NewsTable newsTable = new NewsTable();
            if (id > 0)
            {
                newsTable = mgttcEntities.NewsTables.FirstOrDefault(x => x.ID == id);
            }
            NewsTableModel newsTableModel = new NewsTableModel
            {
                ID = newsTable.ID,
                NewsDate = newsTable.NewsDate,
                NewsHeadLine = newsTable.NewsHeadLine,
                NewsText = newsTable.NewsText
            };
            return View(newsTableModel);
        }

        [HttpPost]
        public ActionResult Create(NewsTableModel newsTableModel)
        {
            try
            {
                NewsTable newsTable = new NewsTable
                {
                    ID = newsTableModel.ID,
                    NewsDate = newsTableModel.NewsDate,
                    NewsHeadLine = newsTableModel.NewsHeadLine,
                    NewsText = newsTableModel.NewsText
                };
                if (base.ModelState.IsValid)
                {
                    if (newsTable.ID > 0)
                    { 
                        mgttcEntities.Entry(newsTable).State = EntityState.Modified;
                    }
                    else
                    {
                        mgttcEntities.NewsTables.Add(newsTable); 
                    }
                    return RedirectToAction("Index");
                }
                return View(newsTableModel);
            }
            catch (Exception)
            {
                return View(newsTableModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            new NewsTable();
            if (id > 0)
            {
                NewsTable news = mgttcEntities.NewsTables.FirstOrDefault((NewsTable x) => x.ID == id);
                mgttcEntities.NewsTables.Remove(news);
            }
            return RedirectToAction("Index");
        }
    }
}