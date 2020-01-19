using System.Collections.Generic;
using System.Linq;
using ITI.Data;
using System.Data.Entity;

namespace ITI.Repository.Repository
{
    public class StaffRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public StaffRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<StaffTable> GetStaff()
        {
            return iTIDataEntities.StaffTables.ToList();
        }
        public StaffTable GetStaffById(int id)
        {
            return iTIDataEntities.StaffTables.FirstOrDefault(x => x.ID == id);
        }
        public StaffTable InsertStaff(StaffTable staff)
        {
            var inserted = iTIDataEntities.StaffTables.Add(staff);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public StaffTable UpdateStaff(StaffTable staff)
        {
            iTIDataEntities.Entry(staff).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return staff;
        }
        public void DeleteStaff(int id)
        {
            var StaffTechnical = iTIDataEntities.StaffTables.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.StaffTables.Remove(StaffTechnical);
            iTIDataEntities.SaveChanges();
        }
    }
}
