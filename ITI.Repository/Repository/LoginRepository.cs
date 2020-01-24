using ITI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ITI.Repository.Repository
{
    public class LoginRepository
    {
        protected MGTTCEntities mGTTCEntities;
        public LoginRepository()
        {
            mGTTCEntities = new MGTTCEntities();
        }
        public List<Login> GetLogins()
        {
            return mGTTCEntities.Logins.ToList();
        }
        public Login GetLoginById(int id)
        {
            return mGTTCEntities.Logins.FirstOrDefault(x => x.id == id);
        }
    }
}
