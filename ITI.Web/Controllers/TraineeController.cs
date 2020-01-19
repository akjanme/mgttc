using ITI.Data;
using ITI.Models;
using ITI.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class TraineeController : Controller
    {
        private readonly TraineeRepository traineeRepository;
        private readonly ITIResultRepository itIResultRepository;
        private readonly AdmissionCriteriaRepository admissionCriteriaRepository;
        public TraineeController()
        {
            traineeRepository = new TraineeRepository();
            itIResultRepository = new ITIResultRepository();
            admissionCriteriaRepository = new AdmissionCriteriaRepository();
        }  
        // GET: Trainee
        public ActionResult TraineeList()
        {
            var students = traineeRepository.GetTarineeLists().Select(x => new TraineeModel { ID = x.ID, AverageInspection = x.AverageInspection, InspectionFirst = x.InspectionFirst, InspectionSecond = x.InspectionSecond, InspectionThird = x.InspectionThird, Trade = x.Trade, TraineesFirst = x.TraineesFirst, TraineesSecond = x.TraineesSecond, TraineesThird = x.TraineesThird, UnitFirst = x.UnitFirst, UnitSecond = x.UnitSecond, UnitThird = x.UnitThird });
            return View(students);
        }
        public ActionResult Result()
        {
            var students = itIResultRepository.GetiTIResults().Select(x => new ITIResultModel { ID = x.ID, CertificateIssued=x.CertificateIssued, Trade = x.Trade, TotalAppeared=x.TotalAppeared, TotalStudent=x.TotalStudent, Session=x.Session, Passout=x.Passout});
            return View(students);
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
       
        public ActionResult Syllabus()
        {
            return View();
        }
        public ActionResult TradeWiseDetails()
        {
            return View();
        }
    }
}