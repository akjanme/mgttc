using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ITI.Models
{
    public class InstituteDetailModel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string RegNo { get; set; }

        public string CertficateLink { get; set; }

        public HttpPostedFileBase PhotoName { get; set; }
    }

}
