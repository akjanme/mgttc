using ITI.Data;
using ITI.Models;
using ITI.Repository.Repository;
using ITI.Web.Filter;
using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class InstituteController : Controller
    {
        private readonly InstituteRepository instituteRepository;
        private readonly AdmissionCriteriaRepository admissionCriteriaRepository;
        public InstituteController()
        {
            instituteRepository = new InstituteRepository();
            admissionCriteriaRepository = new AdmissionCriteriaRepository();
        }


        // GET: Admin/Institute
        public ActionResult Index()
        {
            var model = instituteRepository.GetInstitute();
            return View(model);
        }
        public ActionResult Create()
        {
            var model = new InstituteDetailModel();
            var instituteDetail = instituteRepository.GetInstitute().FirstOrDefault();
            if (instituteDetail != null)
            {
                model.ID = instituteDetail.ID;
                model.Name = instituteDetail.Name;
                model.RegNo = instituteDetail.RegNo;
                model.CertficateLink = instituteDetail.CertficateLink;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(InstituteDetailModel instituteDetailModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string _PhotoName = "";
                    if (instituteDetailModel.PhotoName != null && instituteDetailModel.PhotoName.ContentLength > 0)
                    {
                        _PhotoName = Path.GetFileName(instituteDetailModel.PhotoName.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _PhotoName);
                        instituteDetailModel.PhotoName.SaveAs(_path);
                    }
                    InstituteDetail institute = new InstituteDetail()
                    {
                        ID = instituteDetailModel.ID,
                        Name = instituteDetailModel.Name,
                        RegNo = instituteDetailModel.RegNo,
                        CertficateLink = "/UploadedFiles/" + _PhotoName
                    };

                    if (instituteDetailModel.ID > 0)
                    {
                        instituteRepository.UpdateInstituteDetail(institute);
                    }
                    else
                    {
                        instituteRepository.InsertInstituteDetail(institute);
                    }
                }
                else
                {
                    return View(instituteDetailModel);
                }
                return RedirectToAction("Index","Manage", new { area = "Admin" });
            }
            catch (Exception )
            {
                return View(instituteDetailModel);
            }
        }




        public ActionResult AdmissionCriteria()
        {
            var model = new AdmissionCriteriaModel();
            var a = admissionCriteriaRepository.GetCriteria();
            if (a != null)
            {
                model = new AdmissionCriteriaModel
                {
                    ID = a.ID,
                    CCE = a.CCE,
                    CriteriaForAddmision = a.CriteriaForAddmision,
                    DateOfAdmissionCompleted = a.DateOfAdmissionCompleted,
                    DateOfNotice = a.DateOfNotice,
                    IsCopyEnclosed = a.IsCopyEnclosed,
                    IsTraineeQualified = a.IsTraineeQualified,
                    LastDateOfReciept = a.LastDateOfReciept,
                    NumberOfApplication = a.NumberOfApplication,
                    SessionStartDate = a.SessionStartDate
                };
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AdmissionCriteria(AdmissionCriteriaModel admissionCriteriaModel)
        {
            if (ModelState.IsValid)
            {
                var admissionCriteria = new AdmissionCriteria
                {
                    ID = admissionCriteriaModel.ID,
                    CCE = admissionCriteriaModel.CCE,
                    CriteriaForAddmision = admissionCriteriaModel.CriteriaForAddmision,
                    DateOfAdmissionCompleted = admissionCriteriaModel.DateOfAdmissionCompleted,
                    DateOfNotice = admissionCriteriaModel.DateOfNotice,
                    IsCopyEnclosed = admissionCriteriaModel.IsCopyEnclosed,
                    IsTraineeQualified = admissionCriteriaModel.IsTraineeQualified,
                    LastDateOfReciept = admissionCriteriaModel.LastDateOfReciept,
                    NumberOfApplication = admissionCriteriaModel.NumberOfApplication,
                    SessionStartDate = admissionCriteriaModel.SessionStartDate
                };
                if (admissionCriteriaModel.ID > 0)
                {
                    admissionCriteriaRepository.UpdateAdmissionCriteria(admissionCriteria);
                }
                else
                {
                    admissionCriteriaRepository.InsertAdmissionCriteria(admissionCriteria);
                }
                return RedirectToAction("admin", "Manage");
            }
            return View(admissionCriteriaModel);
        }
    }
}