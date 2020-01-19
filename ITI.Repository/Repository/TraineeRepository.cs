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
    public class TraineeRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public TraineeRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<TarineeList> GetTarineeLists()
        {
            return iTIDataEntities.TarineeLists.ToList();
        }
        public TarineeList GetTarineeListById (int id)
        {
            return iTIDataEntities.TarineeLists.FirstOrDefault(x => x.ID == id);
        }
        public TarineeList InsertTarineeList(TarineeList tarineeList)
        {
            var inserted = iTIDataEntities.TarineeLists.Add(tarineeList);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public TarineeList UpdateTarineeList(TarineeList tarineeList)
        {
            iTIDataEntities.Entry(tarineeList).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return tarineeList;
        }
        public void DeleteTarineeLists(int id)
        {
            var student = iTIDataEntities.TarineeLists.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.TarineeLists.Remove(student);
            iTIDataEntities.SaveChanges();
        }
    }
}
