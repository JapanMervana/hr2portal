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
    
    public partial class UsersFP : HR2.EF.DAL.IEFEntity
    {
        public int UsersFPId { get; set; }
        public string EmployeeCodeInDevice { get; set; }
        public string BioVersion { get; set; }
        public Nullable<int> FID { get; set; }
        public string FingerPrint { get; set; }
    }
}