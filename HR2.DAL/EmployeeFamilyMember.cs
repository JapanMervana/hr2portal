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
    
    public partial class EmployeeFamilyMember : HR2.EF.DAL.IEFEntity
    {
        public int EmployeeFamilyMemberId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> IsNominated { get; set; }
        public Nullable<int> IsDependent { get; set; }
        public Nullable<int> IsCoveredUnderMediclaim { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Profession { get; set; }
        public string Relationship { get; set; }
        public string MedicalHistory { get; set; }
    }
}
