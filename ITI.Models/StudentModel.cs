using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ITI.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public Nullable<int> RollNo { get; set; }
        [Required(ErrorMessage ="Student Name Is Required")]
        public string Sname { get; set; }
        [Required(ErrorMessage = "FatherName Is Required")]
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        [Required(ErrorMessage ="Gender is requried")]

        public string Gender { get; set; }
        [Required(ErrorMessage = "Category Name Is Required")]
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }
        public string MobileNo { get; set; }
        public string Faculty { get; set; }
        [Required(ErrorMessage = "Session Is Required")]
        public string Session { get; set; }
    }
}
