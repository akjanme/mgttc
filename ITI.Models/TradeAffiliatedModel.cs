using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class TradeAffiliatedModel
    {
        public int ID { get; set; }
        public string TradeName { get; set; }
        public Nullable<int> FirstUnit { get; set; }
        public Nullable<int> SecondUnit { get; set; }
        public Nullable<int> ThirdUnit { get; set; }
        public string DgetRef { get; set; }
        public string Remark { get; set; }
        public string SessionYear { get; set; }
    }
}
