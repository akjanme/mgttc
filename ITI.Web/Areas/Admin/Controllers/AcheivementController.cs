using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Data;
using ITI.Repository.Repository;
using ITI.Models;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class AcheivementController : Controller
    {
        private readonly AcheivementRepository acheivementRepository;
        public AcheivementController()
        {
            acheivementRepository = new AcheivementRepository();
        }
        public ActionResult Index()
        {
            var acheivements = acheivementRepository.GetAcheivements().Select(x=> new AcheivementModel {ID=x.ID,NameofAward=x.NameofAward,Remarks=x.Remarks,SchemeName=x.SchemeName,WonBy=x.WonBy,Year=x.Year });
            return View(acheivements);
        }
        public ActionResult Create(int id = 0)
        {
            Acheivement acheivement = new Acheivement();
            if (id > 0)
            {
                acheivement = acheivementRepository.GetAcheivementById(id);
            }
            AcheivementModel acheivementModel = new AcheivementModel
            {
                ID = acheivement.ID,
                NameofAward=acheivement.NameofAward,
                Remarks=acheivement.Remarks,
                SchemeName=acheivement.SchemeName,
                WonBy=acheivement.WonBy,
                Year=acheivement.Year
            };
            return View(acheivementModel);
        }

        [HttpPost]
        public ActionResult Create(AcheivementModel acheivementModel)
        {
            try
            {
                Acheivement acheivement = new Acheivement
                {
                    ID = acheivementModel.ID,
                    NameofAward = acheivementModel.NameofAward,
                    Remarks = acheivementModel.Remarks,
                    SchemeName = acheivementModel.SchemeName,
                    WonBy = acheivementModel.WonBy,
                    Year = acheivementModel.Year
                };
                if (ModelState.IsValid)
                {
                    if (acheivement.ID > 0)
                    {
                        acheivementRepository.UpdateAcheivement(acheivement);
                    }
                    else
                    {
                        acheivementRepository.InsertAcheivement(acheivement);
                    }
                }
                else
                {
                    return View(acheivementModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(acheivementModel);
            }
        }
        public ActionResult Delete(int id = 0)
        {
            Acheivement acheivement = new Acheivement();
            if (id > 0)
            {
                acheivementRepository.DeleteAcheivements(id);
            }
            return RedirectToAction("Index");
        }
    }
}