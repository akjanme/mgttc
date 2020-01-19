using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ITI.Models
{
    public class StaffModel
    {
        public int ID { get; set; }
        public string Designation { get; set; }
        [Required(ErrorMessage ="Name Required")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Selection Requrid ")]
        public string Staff { get; set; } 
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateOfJoin { get; set; } 
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string SchoolMatric { get; set; }
        [Required (ErrorMessage="Qualifiucation Required")]
        public string Qualification { get; set; }
        public string Experience { get; set; }
        public string Salary { get; set; }
        public string ACDetails { get; set; } 
        public string PhotoGraph { get; set; }
        public HttpPostedFileBase FileName { get; set; }
    }
}
