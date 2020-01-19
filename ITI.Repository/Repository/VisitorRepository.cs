using System;
using ITI.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Repository.Repository
{
    public class VisitorRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public VisitorRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<Visitor> GetVisitors()
        {
            return iTIDataEntities.Visitors.ToList();
        }
        public Visitor GetVisitorById(int id)
        {
            return iTIDataEntities.Visitors.FirstOrDefault(x => x.ID == id);
        }
        public Visitor InsertVisitor(Visitor visitor)
        {
            var inserted = iTIDataEntities.Visitors.Add(visitor);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public Visitor UpdateVisitor(Visitor visitor)
        {
            iTIDataEntities.Entry(visitor).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return visitor;
        }
        public void DelecteVisitor(int id)
        {
            var Visitor = iTIDataEntities.Visitors.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.Visitors.Remove(Visitor);
            iTIDataEntities.SaveChanges();
        }
    }
}
