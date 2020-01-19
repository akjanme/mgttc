using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Dto
{
    public class PlacementTable
    {
        public int Id { get; set; }
        public string Roll_No { get; set; }
        public string Name { get; set; }
        public string Trade { get; set; }
        public string PassingYear { get; set; }
        public string Org_Name { get; set; }
        public Nullable<int> SalaryOnJoin { get; set; }
    }
}
