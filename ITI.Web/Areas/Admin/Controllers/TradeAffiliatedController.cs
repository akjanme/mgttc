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
    public class TradeAffiliatedController : Controller
    {
        private readonly TradeAffiliatedRepository tradeAffiliatedRepository;
        public TradeAffiliatedController()
        {
            tradeAffiliatedRepository = new TradeAffiliatedRepository();
        }
        // GET: Admin/TradeAffiliated
        public ActionResult Index()
        {
            var tas = tradeAffiliatedRepository.GetTrades().Select(x => new TradeAffiliatedModel { ID = x.ID, TradeName = x.TradeName, SessionYear=x.SessionYear, FirstUnit = x.FirstUnit, SecondUnit = x.SecondUnit, ThirdUnit = x.ThirdUnit, DgetRef=x.DgetRef, Remark=x.Remark });
            return View(tas);
        }
        public ActionResult Create(int id = 0)
        {
            TradeAffiliated tradeAffiliated = new TradeAffiliated();
            if (id > 0)
            {
                tradeAffiliated = tradeAffiliatedRepository.GetTradeAffiliatedById(id);
            }
            ViewBag.Trade = StaticData.GetTrade();
            TradeAffiliatedModel tradeAffiliatedModel = new TradeAffiliatedModel
            {
                ID = tradeAffiliated.ID,
                TradeName = tradeAffiliated.TradeName,
                FirstUnit = tradeAffiliated.FirstUnit,
                SecondUnit = tradeAffiliated.SecondUnit,
                ThirdUnit = tradeAffiliated.ThirdUnit, 
                DgetRef = tradeAffiliated.DgetRef,
                SessionYear=tradeAffiliated.SessionYear,
                Remark = tradeAffiliated.Remark
            };
            return View(tradeAffiliatedModel);
        }

        [HttpPost]
        public ActionResult Create(TradeAffiliatedModel tradeAffiliatedModel)
        {
            try
            {
                TradeAffiliated tradeAffiliated = new TradeAffiliated
                {
                    ID = tradeAffiliatedModel.ID,
                    TradeName = tradeAffiliatedModel.TradeName,
                    FirstUnit = tradeAffiliatedModel.FirstUnit,
                    SecondUnit = tradeAffiliatedModel.SecondUnit,
                    ThirdUnit = tradeAffiliatedModel.ThirdUnit, 
                    SessionYear=tradeAffiliatedModel.SessionYear,
                    DgetRef = tradeAffiliatedModel.DgetRef,
                    Remark = tradeAffiliatedModel.Remark
                };
                if (ModelState.IsValid)
                {
                    if (tradeAffiliated.ID > 0)
                    {
                        tradeAffiliatedRepository.UpdateTradeAffiliated(tradeAffiliated);
                    }
                    else
                    {
                        tradeAffiliatedRepository.InsertTradeAffiliated(tradeAffiliated);
                    }
                }
                else
                {
                    return View(tradeAffiliatedModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(tradeAffiliatedModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            TradeAffiliationSou tradeAffiliationSou = new TradeAffiliationSou();
            if (id > 0)
            {
                tradeAffiliatedRepository.DelectTradeAffiliated(id);
            }
            return RedirectToAction("Index");
        }
    }
}