using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ITI.Models
{
    public class ImageModel
    {
        [Required(ErrorMessage = "this fild is required")]
        public string ImagDesc { get; set; }

        public int ID { get; set; }

        public string ImageUrl { get; set; }

        public HttpPostedFileBase FileName { get; set; }
    }
}
