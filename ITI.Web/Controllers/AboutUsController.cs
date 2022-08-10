using ITI.Web.Data;
using ITI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class AboutUsController : Controller
    {
        //private readonly InspectionRepository inspectionRepository;
        //private readonly ImageRepository imageRepository;
        //private readonly VisitorRepository visitorRepository;
        //private MgttcEntities db;
        //public AboutUsController()
        //{
        //    imageRepository = new ImageRepository();
        //    inspectionRepository = new InspectionRepository();
        //    visitorRepository = new VisitorRepository();
        //    db = new MgttcEntities();
        //}
        //// GET: AboutUs
        //public ActionResult AffiliatedTradeDetail()
        //{
        //    AffilationModel affilationModel = new AffilationModel();
        //    affilationModel.TradeAffilatedList = db.TradeAffiliateds.Select(x=> new TradeAffiliatedModel { ID=x.ID, DgetRef=x.DgetRef, FirstUnit=x.FirstUnit, Remark=x.Remark, SecondUnit=x.SecondUnit, SessionYear=x.SessionYear, ThirdUnit=x.ThirdUnit,TradeName=x.TradeName }).ToList();
        //    affilationModel.TradeAffiliationSouList = db.TradeAffiliationSous.Select(x=> new TradeAffiliationSouModel { ID = x.ID, FirstUnit = x.FirstUnit, SecondUnit = x.SecondUnit, SessionYear = x.SessionYear, ThirdUnit = x.ThirdUnit, TradeName = x.TradeName }).ToList();
        //    return View(affilationModel);
        //}
        //public ActionResult Gallery()
        //{
        //    var image = imageRepository.GetImageGalleries().Select(x => new ImageModel { ID = x.ID, ImagDesc = x.ImagDesc, ImageUrl = x.ImageUrl });
        //    return View(image);
        //}
        //public ActionResult InspectionDetail()
        //{
        //    var inspection = inspectionRepository.GetInspectionDetails().Select(x => new InspectionModel { ID = x.ID, DateOfInsp = x.DateOfInsp, InspectorAdrs = x.InspectorAdrs, InspectorName = x.InspectorName, InspectorDesg = x.InspectorDesg, PurposeOfInsp = x.PurposeOfInsp, Report = x.Report });
        //    return View(inspection);
        //}
        //public ActionResult Scheme()
        //{
        //    return View();
        //}
        //public ActionResult Visitors()
        //{
        //    var visitor = visitorRepository.GetVisitors().Select(x => new VisitorModel { ID = x.ID, vName=x.vName, Comment=x.Comment });
        //    return View(visitor);
        //}
        //public ActionResult ApplicationFormat()
        //{
        //    return View();
        //}
        //public ActionResult CourtCase()
        //{
        //    return View();
        //} 
    }
}