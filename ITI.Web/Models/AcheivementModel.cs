using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class AcheivementModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "name is required")]
        public string NameofAward { get; set; }

        [Required(ErrorMessage = "Scheme is required")]
        public string SchemeName { get; set; }

        [Required(ErrorMessage = "name of won is required")]
        public string WonBy { get; set; }

        [Required(ErrorMessage = "year is required")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Remarks is required")]
        public string Remarks { get; set; }
    }

}
