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
    
    public partial class EmployeeShift : HR2.EF.DAL.IEFEntity
    {
        public int EmployeeShiftId { get; set; }
        public int ShiftId { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime Shiftdate { get; set; }
        public string ShiftType { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
    }
}
