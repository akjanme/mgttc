using ITI.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Repository.Repository
{
    public class InstituteRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public InstituteRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<InstituteDetail> GetInstitute()
        {
            return iTIDataEntities.InstituteDetails.ToList();
        }
        public InstituteDetail InsertInstituteDetail(InstituteDetail instituteDetail)
        {
            var inserted = iTIDataEntities.InstituteDetails.Add(instituteDetail);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public InstituteDetail UpdateInstituteDetail(InstituteDetail instituteDetail)
        {
            iTIDataEntities.Entry(instituteDetail).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return instituteDetail;
        }
    }
}
