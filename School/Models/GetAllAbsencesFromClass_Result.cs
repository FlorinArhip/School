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
    
    public partial class GetAllAbsencesFromClass_Result
    {
        public int id_absence { get; set; }
        public System.DateTime date { get; set; }
        public bool is_justified { get; set; }
        public bool can_be_justified { get; set; }
        public int fk_student { get; set; }
        public int fk_teacher_subject { get; set; }
        public int id_student { get; set; }
        public Nullable<bool> is_debtor { get; set; }
        public Nullable<double> annual_grade { get; set; }
        public Nullable<int> fk_class { get; set; }
    }
}
