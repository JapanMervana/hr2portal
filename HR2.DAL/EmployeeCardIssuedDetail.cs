//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR2.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeCardIssuedDetail : HR2.EF.DAL.IEFEntity
    {
        public int EmployeeCardIssuedDetailsId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<int> NoOfTime { get; set; }
        public string CardNumber { get; set; }
    }
}
