//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI.Web.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocCategoryImage
    {
        public int ID { get; set; }
        public Nullable<int> DocCategoryID { get; set; }
        public string DocPath { get; set; }
    
        public virtual DocCategory DocCategory { get; set; }
    }
}
