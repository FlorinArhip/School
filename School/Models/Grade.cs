//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public int id_grade { get; set; }
        public int mark { get; set; }
        public System.DateTime date { get; set; }
        public bool is_midterm { get; set; }
        public int fk_situation { get; set; }
    
        public virtual Situation_Subject Situation_Subject { get; set; }
    }
}
