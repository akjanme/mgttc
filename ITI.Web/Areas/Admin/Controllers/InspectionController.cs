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
    public class InspectionController : Controller
    {
        private readonly InspectionRepository inspectionRepository;
        public InspectionController()
        {
            inspectionRepository = new InspectionRepository();
        }
        // GET: Admin/Inspection
        public ActionResult Index()
        {
            var inspection = inspectionRepository.GetInspectionDetails().Select(x => new InspectionModel { ID = x.ID, DateOfInsp = x.DateOfInsp, InspectorAdrs = x.InspectorAdrs, InspectorName = x.InspectorName, InspectorDesg = x.InspectorDesg, PurposeOfInsp = x.PurposeOfInsp, Report = x.Report });
            return View(inspection);
        }
        public ActionResult Create(int id = 0)
        {
            InspectionDetail inspectionDetail = new InspectionDetail(); 
            if (id > 0)
            {
                inspectionDetail = inspectionRepository.GetInspectionDetailById(id);
            }
            InspectionModel inspectionModel = new InspectionModel
            {
                ID = inspectionDetail.ID,
                DateOfInsp = inspectionDetail.DateOfInsp,
                PurposeOfInsp = inspectionDetail.PurposeOfInsp,
                InspectorName = inspectionDetail.InspectorName,
                InspectorDesg = inspectionDetail.InspectorDesg,
                InspectorAdrs = inspectionDetail.InspectorAdrs,
                Report = inspectionDetail.Report
            };
            return View(inspectionModel);
        }

        [HttpPost]
        public ActionResult Create(InspectionModel inspectionModel)
        {
            try
            {
                InspectionDetail inspectionDetail = new InspectionDetail 
                {
                    ID = inspectionModel.ID,
                    DateOfInsp = inspectionModel.DateOfInsp,
                    PurposeOfInsp = inspectionModel.PurposeOfInsp,
                    InspectorName = inspectionModel.InspectorName,
                    InspectorDesg = inspectionModel.InspectorDesg,
                    InspectorAdrs = inspectionModel.InspectorAdrs,
                    Report = inspectionModel.Report
                };
                if (ModelState.IsValid)
                {
                    if (inspectionDetail.ID > 0)
                    {
                        inspectionRepository.UpdateInspectionDetail(inspectionDetail);
                    }
                    else
                    {
                        inspectionRepository.InsertInspectionDetail(inspectionDetail);
                    }
                }
                else
                {
                    return View(inspectionModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(inspectionModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            InspectionDetail inspectionDetail = new InspectionDetail();
            if (id > 0)
            {
                inspectionRepository.DelectInspectionDetail(id);
            }
            return RedirectToAction("Index");
        }
    }
}