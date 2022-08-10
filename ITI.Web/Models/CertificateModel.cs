using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class CertificateModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter total passout")]
        public int? No_Passout { get; set; }

        [Required(ErrorMessage = "Enter ntc number")]
        public int? ntcIssued { get; set; }

        [Required(ErrorMessage = "Enter total Issued Students")]
        public int? toIssued { get; set; }
    }

}
