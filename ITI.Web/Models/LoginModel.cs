using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{

    public class LoginModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "User Name")]
        [StringLength(30)]
        public string User_Name { get; set; }

        [Required(ErrorMessage = "PassWord is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(10)]
        public string Password { get; set; }
    }
}
