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
        public Nullable<int> UnitFirst { get; set; }
        public Nullable<int> UnitSecond { get; set; }
        public Nullable<int> UnitThird { get; set; }
        public Nullable<int> TraineesFirst { get; set; }
        public Nullable<int> TraineesSecond { get; set; }
        public Nullable<int> TraineesThird { get; set; }
        public Nullable<int> InspectionFirst { get; set; }
        public Nullable<int> InspectionSecond { get; set; }
        public Nullable<int> InspectionThird { get; set; }
        public string AverageInspection { get; set; }
    }
}
