using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class NewsTableModel
    {
        [Required(ErrorMessage = "required")]
        public DateTime? NewsDate { get; set; }

        [Required(ErrorMessage = "required")]
        public string NewsHeadLine { get; set; }

        [Required(ErrorMessage = "required")]
        public string NewsText { get; set; }

        public int ID { get; set; }
    }

}
