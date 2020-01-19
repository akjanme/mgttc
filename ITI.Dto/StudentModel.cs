using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Dto
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string EnrollNo { get; set; }
        public string Category { get; set; }
        public string Trade { get; set; }
        public Nullable<int> Unit { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public string Session { get; set; }
        public string Qualification { get; set; }
        public Nullable<System.DateTime> DateofAddmission { get; set; }
    }
}
