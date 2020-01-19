using ITI.Data;
using ITI.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Models;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class CertificateController : Controller
    {
        private readonly CertificateRepository certificateRepository;
        public CertificateController()
        {
            certificateRepository = new CertificateRepository();
        }
        public ActionResult Index()
        {
            var certificates = certificateRepository.GetCertificates().Select(x=> new CertificateModel { ID = x.ID, No_Passout = x.No_Passout, ntcIssued = x.ntcIssued, toIssued = x.toIssued });
            return View(certificates);
        }
        public ActionResult Create(int id = 0)
        {
            Certificate certificate = new Certificate();
            if (id > 0)
            {
                certificate = certificateRepository.GetCertificateById(id);
            }
            CertificateModel certificateModel = new CertificateModel
            {
                ID = certificate.ID,
                No_Passout=certificate.No_Passout,
                ntcIssued=certificate.ntcIssued,
                toIssued=certificate.toIssued
            };
            return View(certificateModel);
        }

        [HttpPost]
        public ActionResult Create(CertificateModel certificateModel)
        {
            try
            {
                Certificate certificate = new Certificate
                {
                    ID = certificateModel.ID,
                    No_Passout = certificateModel.No_Passout,
                    ntcIssued = certificateModel.ntcIssued,
                    toIssued = certificateModel.toIssued
                };
                if (ModelState.IsValid)
                {
                    if (certificate.ID > 0)
                    {
                        certificateRepository.UpdateCertificate(certificate);
                    }
                    else
                    {
                        certificateRepository.InsertCertificate(certificate);
                    }
                }
                else
                {
                    return View(certificateModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(certificateModel);
            }
        }
        public ActionResult Delete(int id = 0)
        {
            Certificate certificate = new Certificate();
            if (id > 0)
            {
                certificateRepository.DeleteCertificates(id);
            }
            return RedirectToAction("Index");
        }
    }
}