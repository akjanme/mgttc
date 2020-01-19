using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Data;

namespace ITI.Repository.Repository
{
    public class PlacementTableRepository
    {
        protected ITIDataEntities iTIDataEntities;

        public PlacementTableRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<PlacementTable> GetPlacementTables()
        {
            return iTIDataEntities.PlacementTables.ToList();
        }
        public PlacementTable GetPlacementbyID(int id)
        {
            return iTIDataEntities.PlacementTables.FirstOrDefault(x => x.ID == id);
        }
        public PlacementTable InsertPlacement(PlacementTable placementTable)
        {
            var inserted = iTIDataEntities.PlacementTables.Add(placementTable);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public PlacementTable UpdatePlacement(PlacementTable placementTable)
        {
            iTIDataEntities.Entry(placementTable).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return placementTable;
        }
        public void DeletePlacement(int id)
        {
            var placement = iTIDataEntities.PlacementTables.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.PlacementTables.Remove(placement);
            iTIDataEntities.SaveChanges();
        }
    }
}
