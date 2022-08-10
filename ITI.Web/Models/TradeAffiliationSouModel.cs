using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class TradeAffiliationSouModel
    {
        public int ID { get; set; }

        public string TradeName { get; set; }

        public int? FirstUnit { get; set; }

        public int? SecondUnit { get; set; }

        public int? ThirdUnit { get; set; }

        public string SessionYear { get; set; }
    }
}
