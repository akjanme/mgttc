using ITI.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Repository.Repository
{ 
     public class AdmissionCriteriaRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public AdmissionCriteriaRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        } 
        public AdmissionCriteria GetCriteria()
        {
            return iTIDataEntities.AdmissionCriterias.FirstOrDefault();
        }
        public AdmissionCriteria InsertAdmissionCriteria(AdmissionCriteria AdmissionCriteria)
        {
            var inserted = iTIDataEntities.AdmissionCriterias.Add(AdmissionCriteria);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public AdmissionCriteria UpdateAdmissionCriteria(AdmissionCriteria AdmissionCriteria)
        {
            iTIDataEntities.Entry(AdmissionCriteria).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return AdmissionCriteria;
        }
    }
}
