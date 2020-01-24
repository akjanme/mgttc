using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class StaffModel
    {
        public int ID { get; set; }
        public string StaffName { get; set; }
        public string FatherName { get; set; }
        public string Designation { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> DateOfJoin { get; set; }
        public Nullable<int> Salary { get; set; }
        public Nullable<int> PanNumber { get; set; }
        public Nullable<int> AadharNumber { get; set; }
        public string Experience { get; set; }
        public string StaffType { get; set; }
        public string TeachSubFirst { get; set; }
        public string TeachSubSecond { get; set; }
        public string Subject { get; set; }
        public string SubjectNumFirst { get; set; }
        public string SubjectNumSecond { get; set; }
    }
}
