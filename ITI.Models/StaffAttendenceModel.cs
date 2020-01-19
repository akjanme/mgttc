using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class StaffAttendenceModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "required")]
        public string Month { get; set; }
        [Required(ErrorMessage = "required")]
        public Nullable<int> Attendence { get; set; }
    }
}
