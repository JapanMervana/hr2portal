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
    
    public partial class ShiftGroup : HR2.EF.DAL.IEFEntity
    {
        public int ShiftGroupId { get; set; }
        public string ShiftGroupCode { get; set; }
        public string Description { get; set; }
        public string ShiftGroupName { get; set; }
        public string ShiftIds { get; set; }
    }
}