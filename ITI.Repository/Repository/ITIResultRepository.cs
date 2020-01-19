using ITI.Data;
using ITI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ITI.Repository.Repository
{
    public class ITIResultRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public ITIResultRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<ITIResult> GetiTIResults()
        {
            return iTIDataEntities.ITIResults.ToList();
        }
        public ITIResult GetResultListById(int id)
        {
            return iTIDataEntities.ITIResults.FirstOrDefault(x => x.ID == id);
        }
        public ITIResult InsertITIResult(ITIResult iTIResult)
        {
            var inserted = iTIDataEntities.ITIResults.Add(iTIResult);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public ITIResult UpdateITIResult(ITIResult iTIResult)
        {
            iTIDataEntities.Entry(iTIResult).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return iTIResult;
        }
        public void DeleteITIResults(int id)
        {
            var student = iTIDataEntities.ITIResults.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.ITIResults.Remove(student);
            iTIDataEntities.SaveChanges();
        }
    }
}
