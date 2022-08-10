using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class InspectionModel
    {
        public int ID { get; set; }

        public DateTime? DateOfInsp { get; set; }

        public string PurposeOfInsp { get; set; }

        public string InspectorName { get; set; }

        public string InspectorDesg { get; set; }

        public string InspectorAdrs { get; set; }

        public string Report { get; set; }
    }

}
