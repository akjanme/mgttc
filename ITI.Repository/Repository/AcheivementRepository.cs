using ITI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ITI.Repository.Repository
{
    public class AcheivementRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public AcheivementRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<Acheivement> GetAcheivements()
        {
            return iTIDataEntities.Acheivements.ToList();
        }
        public Acheivement GetAcheivementById(int id)
        {
            return iTIDataEntities.Acheivements.FirstOrDefault(x => x.ID == id);
        }
        public Acheivement InsertAcheivement(Acheivement acheivement)
        {
            var inserted = iTIDataEntities.Acheivements.Add(acheivement);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public Acheivement UpdateAcheivement(Acheivement acheivement)
        {
            iTIDataEntities.Entry(acheivement).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return acheivement;
        }
        public void DeleteAcheivements(int id)
        {
            var acheivement = iTIDataEntities.Acheivements.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.Acheivements.Remove(acheivement);
            iTIDataEntities.SaveChanges();
        }
    }
}
