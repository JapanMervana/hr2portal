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
    
    public partial class Holiday : HR2.EF.DAL.IEFEntity
    {
        public int HolidayId { get; set; }
        public string HolidayName { get; set; }
        public int CompanyId { get; set; }
        public System.DateTime HolidayDate { get; set; }
        public string Description { get; set; }
        public int RecordStatus { get; set; }
        public string HolidayType { get; set; }
        public Nullable<int> HolidayGroupId { get; set; }
    }
}