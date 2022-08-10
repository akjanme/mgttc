using ITI.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ITI.Models
{
    public class DocumentModel
    { 
        public long ID { get; set; }
        [Required]
        public string DocName { get; set; }
        public string DocUrl { get; set; }
        public string DocDescription { get; set; }

        [Required]
        public HttpPostedFileBase Document { get; set; }
    }
    public class DocumentViewModel
    {
        public List<Document> Documents { get; set; }
        public DocumentModel Document { get; set; }

    }
}
