using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Model
{
    public class StudentModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter student name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "FatherName is required")]
        public string FatherName { get; set; }
        [MinLength(4)]
        [Required(ErrorMessage = "EnollNo is required")]
        [Range(minimum: 0, maximum: 1000000)]
        public string EnrollNo { get; set; }
        public string Category { get; set; }
        public string Trade { get; set; }
        public Nullable<int> Unit { get; set; }
        [Required(ErrorMessage = "DateOfBirth is required")]
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public string Session { get; set; }
        [Required(ErrorMessage = "Qualification is required")]
        public string Qualification { get; set; }
        [Required(ErrorMessage = "DateOfAddmission is required")]
        public Nullable<System.DateTime> DateofAddmission { get; set; }
    }
}