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
        protected ITIDataEntities iTIDataEntities;
        public LoginRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<Login> GetLogins()
        {
            return iTIDataEntities.Logins.ToList();
        }
        public Login GetLoginById(int id)
        {
            return iTIDataEntities.Logins.FirstOrDefault(x => x.id == id);
        }
    }
}
