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
    
    public partial class Student
    {
        public Student()
        {
            this.Absence = new HashSet<Absence>();
            this.Situation_Subject = new HashSet<Situation_Subject>();
        }
    
        public int id_student { get; set; }
        public Nullable<bool> is_debtor { get; set; }
        public Nullable<double> annual_grade { get; set; }
        public Nullable<int> fk_class { get; set; }
    
        public virtual ICollection<Absence> Absence { get; set; }
        public virtual Class Class { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Situation_Subject> Situation_Subject { get; set; }
    }
}
