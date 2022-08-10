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
        public long ID { get; set; }

        [Required(ErrorMessage = "Please enter student name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Father Name is required")]
        public string FatherName { get; set; }

        public string Category { get; set; }

        [Required(ErrorMessage = "Mother Name is required")]
        public string MotherName { get; set; }

        public DateTime? DateOfAdmit { get; set; }

        [Required(ErrorMessage = "Session year is required")]
        public string Session { get; set; }

        public string Qualification { get; set; }

        public decimal? Percentage { get; set; }

        public decimal? Ptet_Per { get; set; }
    }

}
