using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Data;
using System.Data.Entity;

namespace ITI.Repository.Repository
{
    public class InspectionRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public InspectionRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<InspectionDetail> GetInspectionDetails()
        {
            return iTIDataEntities.InspectionDetails.ToList();
        }
        public InspectionDetail GetInspectionDetailById(int id)
        {
            return iTIDataEntities.InspectionDetails.FirstOrDefault(x => x.ID == id);
        }  
        public InspectionDetail InsertInspectionDetail(InspectionDetail inspectionDetail)
        {
            var inserted = iTIDataEntities.InspectionDetails.Add(inspectionDetail);
            iTIDataEntities.SaveChanges();
            return inserted;
        } 
        public InspectionDetail UpdateInspectionDetail(InspectionDetail inspectionDetail)
        {
            iTIDataEntities.Entry(inspectionDetail).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return inspectionDetail;
        } 
        public void DelectInspectionDetail(int id)
        {
            var detail = iTIDataEntities.InspectionDetails.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.InspectionDetails.Remove(detail);
            iTIDataEntities.SaveChanges();
        } 
    }
}
