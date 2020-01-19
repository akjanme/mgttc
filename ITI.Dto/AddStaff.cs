using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Dto
{
    public class AddStaff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public string Designation { get; set; }
        public string DoJ { get; set; }
        public Nullable<int> OrderNo { get; set; }
    }
}
