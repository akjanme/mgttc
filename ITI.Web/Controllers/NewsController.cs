using ITI.Web.Data;
using ITI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ITI.Web.Controllers
{
    public class NewsController : Controller
    {
        protected MgttcEntities mttcEntities;
        public NewsController()
        {
            mttcEntities = new MgttcEntities();
        }

        public ActionResult Index()
        {
            IEnumerable<NewsTableModel> news = from x in mttcEntities.NewsTables
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
                newsTable = mttcEntities.NewsTables.FirstOrDefault(x => x.ID == id);
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
                        mttcEntities.Entry(newsTable).State = EntityState.Modified;
                        mttcEntities.SaveChanges();
                    }
                    else
                    {
                        NewsTable result = mttcEntities.NewsTables.Add(newsTable);
                        mttcEntities.SaveChanges();
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
                NewsTable news = mttcEntities.NewsTables.FirstOrDefault((NewsTable x) => x.ID == id);
                mttcEntities.NewsTables.Remove(news);
            }
            return RedirectToAction("Index");
        }
    }

}