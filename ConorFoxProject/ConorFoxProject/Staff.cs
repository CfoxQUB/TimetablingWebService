//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConorFoxProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public int StaffId { get; set; }
        public string StaffTitle { get; set; }
        public string StaffForename { get; set; }
        public string StaffSurname { get; set; }
        public string StaffEmail { get; set; }
        public Nullable<int> Course { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastActivity { get; set; }
        public string Password { get; set; }
    }
}
