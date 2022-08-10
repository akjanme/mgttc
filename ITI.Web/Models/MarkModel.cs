using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class MarkModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "required")]
        public string Month { get; set; }

        [Required(ErrorMessage = "required")]
        public string Year { get; set; }

        public int? Practical { get; set; }

        public int? Theory { get; set; }

        public int? Ws_cal_science { get; set; }

        public int? Attendence { get; set; }

        public int? Eng_Drawing { get; set; }

        public int? Total { get; set; }

        public int? Month_Quarter { get; set; }

        public string Trade { get; set; }

        public int? Unit { get; set; }

        public int? Sd_id { get; set; }
    }

}
