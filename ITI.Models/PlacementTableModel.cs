using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class PlacementTableModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Roll_No is required")]
        public string Roll_No { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Trade { get; set; }
        [Required(ErrorMessage = "Passing Year is required")]
        public string PassingYear { get; set; }
        [Required(ErrorMessage = "org_name is required")]
        public string Org_Name { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        public Nullable<int> SalaryOnJoin { get; set; }
    }
}
