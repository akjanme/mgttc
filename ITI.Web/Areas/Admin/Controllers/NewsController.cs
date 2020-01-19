using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Repository.Repository;
using ITI.Data;
using ITI.Models;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class NewsController : Controller
    {
        private readonly NewsRepository newsRepository;
        public NewsController()
        {
            newsRepository = new NewsRepository();
        }
        public ActionResult Index()
        {
            var news = newsRepository.GetNews().Select(x=> new NewsTableModel {ID=x.ID,NewsDate=x.NewsDate,NewsHeadLine=x.NewsHeadLine });
            return View(news);
        }
        public ActionResult Create(int id = 0)
        {
            NewsTable newsTable = new NewsTable();
            if (id > 0)
            {
                newsTable = newsRepository.GetNewsById(id);
            }
            ViewBag.Trade = StaticData.GetTrade();
            NewsTableModel newsTableModel = new NewsTableModel
            {
                ID=newsTable.ID,
                NewsDate=newsTable.NewsDate,
                NewsHeadLine=newsTable.NewsHeadLine,
                NewsText=newsTable.NewsText
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
                if (ModelState.IsValid)
                {
                    if (newsTable.ID > 0)
                    {
                        newsRepository.UpdateNews(newsTable);
                    }
                    else
                    {
                        newsRepository.InsertNews(newsTable);
                    }
                }
                else
                {
                    return View(newsTableModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(newsTableModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            NewsTable newsTable = new NewsTable();
            if (id > 0)
            {
                newsRepository.DeleteNews(id);
            }
            return RedirectToAction("Index");
        }
    }
}