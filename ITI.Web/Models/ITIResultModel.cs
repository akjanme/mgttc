using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class ITIResultModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Total Student")]
        public int? TotalStudent { get; set; }

        [Required(ErrorMessage = "required")]
        public int? TotalAppeared { get; set; }

        [Required(ErrorMessage = "required")]
        public int? Passout { get; set; }

        [Required(ErrorMessage = "required")]
        public int? CertificateIssued { get; set; }

        public string Trade { get; set; }

        [Required(ErrorMessage = "required")]
        public string Session { get; set; }
    }

}
