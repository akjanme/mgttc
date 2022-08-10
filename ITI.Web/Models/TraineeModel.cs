using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class TraineeModel
    {
        public int ID { get; set; }

        public string Trade { get; set; }

        public int? UnitFirst { get; set; }

        public int? UnitSecond { get; set; }

        public int? UnitThird { get; set; }

        public int? TraineesFirst { get; set; }

        public int? TraineesSecond { get; set; }

        public int? TraineesThird { get; set; }

        public int? InspectionFirst { get; set; }

        public int? InspectionSecond { get; set; }

        public int? InspectionThird { get; set; }

        public string AverageInspection { get; set; }
    }

}
