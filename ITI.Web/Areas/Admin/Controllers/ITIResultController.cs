using ITI.Models;
using ITI.Data;
using ITI.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class ITIResultController : Controller
    {
        private readonly ITIResultRepository iTIResultRepository;
        public ITIResultController()
        {
            iTIResultRepository = new ITIResultRepository();
        }
        public ActionResult Index()
        {
            var result = iTIResultRepository.GetiTIResults().Select(x=> new ITIResultModel{ ID = x.ID, Session=x.Session, Trade=x.Trade, CertificateIssued=x.CertificateIssued, Passout=x.Passout, TotalAppeared=x.TotalAppeared,TotalStudent=x.TotalStudent});
            return View(result);
        }
        public ActionResult Create(int id = 0)
        { 
            ITIResult iTIResult = new ITIResult();
            if (id > 0)
            {
                iTIResult = iTIResultRepository.GetResultListById(id);
            }
            ViewBag.Trade = StaticData.GetTrade();
            ITIResultModel iTIResultModel = new ITIResultModel
            {
                ID=iTIResult.ID,
                CertificateIssued=iTIResult.CertificateIssued,
                Passout=iTIResult.Passout,
                Session=iTIResult.Session,
                TotalAppeared=iTIResult.TotalAppeared,
                TotalStudent=iTIResult.TotalStudent,
                Trade=iTIResult.Trade
            };
            return View(iTIResultModel);
        }

        [HttpPost]
        public ActionResult Create(ITIResultModel iTIResultModel)
        {
            try
            {
                ITIResult iTIResult = new ITIResult
                {
                    ID = iTIResultModel.ID,
                    CertificateIssued = iTIResultModel.CertificateIssued,
                    Passout = iTIResultModel.Passout,
                    Session = iTIResultModel.Session,
                    TotalAppeared = iTIResultModel.TotalAppeared,
                    TotalStudent = iTIResultModel.TotalStudent,
                    Trade = iTIResultModel.Trade
                };
                ViewBag.Trade = StaticData.GetTrade();
                if (ModelState.IsValid)
                {
                    if (iTIResult.ID > 0)
                    {
                        iTIResultRepository.UpdateITIResult(iTIResult);                    }
                    else
                    {
                        iTIResultRepository.InsertITIResult(iTIResult); 
                    }
                }
                else
                {
                    return View(iTIResultModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(iTIResultModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            ITIResult iTIResult = new ITIResult();
            if (id > 0)
            {
                iTIResultRepository.DeleteITIResults(id);
            }
            return RedirectToAction("Index");
        }
    }
}