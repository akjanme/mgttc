using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Dto
{
    public class StudentCertificate
    {
        public int Id { get; set; }
        public Nullable<int> No_Passout { get; set; }
        public Nullable<int> ntcIssued { get; set; }
        public Nullable<int> toIssued { get; set; }
    }
}
