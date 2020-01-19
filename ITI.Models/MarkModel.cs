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
        public Nullable<int> Practical { get; set; }
        public Nullable<int> Theory { get; set; }
        public Nullable<int> Ws_cal_science { get; set; }
        public Nullable<int> Attendence { get; set; }
        public Nullable<int> Eng_Drawing { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<int> Month_Quarter { get; set; }
        public string Trade { get; set; }
        public Nullable<int> Unit { get; set; }
        public Nullable<int> Sd_id { get; set; }
    }
}
