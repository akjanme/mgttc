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
    public class TradeAffiliationSouController : Controller
    {
        private readonly TradeAffiliationSouRepository tradeAffiliationSouRepository;
        public TradeAffiliationSouController()
        {
            tradeAffiliationSouRepository = new TradeAffiliationSouRepository();
        }
        // GET: Admin/TradeAffiliationSou
        public ActionResult Index()
        {
            var tasr = tradeAffiliationSouRepository.GetTrades().Select(x => new TradeAffiliationSouModel { ID = x.ID, TradeName=x.TradeName, FirstUnit=x.FirstUnit,SecondUnit=x.SecondUnit, SessionYear=x.SessionYear, ThirdUnit=x.ThirdUnit });
            return View(tasr);
        }
        public ActionResult Create(int id = 0)
        {
            TradeAffiliationSou tradeAffiliationSou = new TradeAffiliationSou(); 
            if (id > 0)
            {
                tradeAffiliationSou = tradeAffiliationSouRepository.GetTradeAffiliationSouById(id);
            }
            ViewBag.Trade = StaticData.GetTrade();
            TradeAffiliationSouModel tradeAffiliationSouModel = new TradeAffiliationSouModel
            {
                ID = tradeAffiliationSou.ID,
                TradeName= tradeAffiliationSou.TradeName,
                FirstUnit=tradeAffiliationSou.FirstUnit,
                SecondUnit= tradeAffiliationSou.SecondUnit,
                ThirdUnit= tradeAffiliationSou.ThirdUnit,
                SessionYear= tradeAffiliationSou.SessionYear, 
            };
            return View(tradeAffiliationSouModel);
        }

        [HttpPost]
        public ActionResult Create(TradeAffiliationSouModel tradeAffiliationSouModel)
        {
            try
            {
                TradeAffiliationSou tradeAffiliationSou = new TradeAffiliationSou
                {
                    ID = tradeAffiliationSouModel.ID,
                    TradeName = tradeAffiliationSouModel.TradeName,
                    FirstUnit = tradeAffiliationSouModel.FirstUnit,
                    SecondUnit = tradeAffiliationSouModel.SecondUnit,
                    ThirdUnit = tradeAffiliationSouModel.ThirdUnit,
                    SessionYear = tradeAffiliationSouModel.SessionYear, 
                };
                if (ModelState.IsValid)
                {
                    if (tradeAffiliationSou.ID > 0)
                    {
                        tradeAffiliationSouRepository.UpdateTradeAffiliationSou(tradeAffiliationSou);
                    }
                    else
                    {
                        tradeAffiliationSouRepository.InsertTradeAffiliationSou(tradeAffiliationSou);
                    }
                }
                else
                {
                    return View(tradeAffiliationSouModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(tradeAffiliationSouModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            TradeAffiliationSou tradeAffiliationSou = new TradeAffiliationSou();
            if (id > 0)
            {
                tradeAffiliationSouRepository.DelectTradeAffiliationSou(id);
            }
            return RedirectToAction("Index");
        }
    }
}