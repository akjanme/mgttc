using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Data;


namespace ITI.Repository.Repository
{
    public class StaffRepository
    {
        protected MGTTCEntities mGTTCEntities;

        public StaffRepository()
        {
            mGTTCEntities = new MGTTCEntities();
        }

        public List<Staff> GetStaffs()
        {
            return mGTTCEntities.Staffs.ToList();
        }
        public Staff GetStaffById(int id)
        {
            return mGTTCEntities.Staffs.FirstOrDefault(x => x.ID == id);
        }
        public Staff InsertStaff(Staff staff)
        {
            var inserted = mGTTCEntities.Staffs.Add(staff);
            mGTTCEntities.SaveChanges();
            return inserted;
        }
        public Staff UpdateStaff(Staff staff)
        {
            mGTTCEntities.Entry(staff).State = EntityState.Modified;
            mGTTCEntities.SaveChanges();
            return staff;
        }
        public void DelectStaffs(int id)
        {
            var staff = mGTTCEntities.Staffs.FirstOrDefault(x => x.ID == id);
            mGTTCEntities.Staffs.Remove(staff);
            mGTTCEntities.SaveChanges();
        }


    }
}
