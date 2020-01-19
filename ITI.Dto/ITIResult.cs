using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Dto
{
    public class ITIResult
    {
        public int id { get; set; }
        public Nullable<int> TotalStudent { get; set; }
        public Nullable<int> TotalAppeared { get; set; }
        public Nullable<int> Passout { get; set; }
        public Nullable<int> CertificateIssued { get; set; }
        public string Trade { get; set; }
        public string Session { get; set; }
    }
}
