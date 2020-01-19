using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Data;
using System.Data.Entity;

namespace ITI.Repository.Repository
{
    public class CertificateRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public CertificateRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<Certificate> GetCertificates()
        {
            return iTIDataEntities.Certificates.ToList();
        }
        public Certificate GetCertificateById(int id)
        {
            return iTIDataEntities.Certificates.FirstOrDefault(x => x.ID == id);
        }
        public Certificate InsertCertificate(Certificate certificate)
        {
            var inserted = iTIDataEntities.Certificates.Add(certificate);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public Certificate UpdateCertificate(Certificate certificate)
        {
            iTIDataEntities.Entry(certificate).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return certificate;
        }
        public void DeleteCertificates(int id)
        {
            var certificate = iTIDataEntities.Certificates.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.Certificates.Remove(certificate);
            iTIDataEntities.SaveChanges();
        }
    }
}
