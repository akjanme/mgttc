using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class FeedbackModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        public string mobile { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email is required")]
        public string email { get; set; }

        [Required(ErrorMessage = "Massage is required")]
        public string massage { get; set; }
    }

}
