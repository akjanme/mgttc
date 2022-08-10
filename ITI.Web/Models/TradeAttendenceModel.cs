using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class TradeAttendenceModel
    {
        public int ID { get; set; }

        public string Trade { get; set; }

        public int? NU_1 { get; set; }

        public int? NU_2 { get; set; }

        public int? NU_3 { get; set; }

        public int? NT_onRoll_1 { get; set; }

        public int? NT_onRoll_2 { get; set; }

        public int? NT_onRoll_3 { get; set; }

        public int? NT_Avail_1 { get; set; }

        public int? NT_Avail_2 { get; set; }

        public int? NT_Avail_3 { get; set; }

        public decimal? Av_Att_1 { get; set; }
    }

}
