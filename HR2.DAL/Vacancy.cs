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
    
    public partial class Vacancy : HR2.EF.DAL.IEFEntity
    {
        public int VacancyId { get; set; }
        public Nullable<int> JobTitleId { get; set; }
        public string VacancyName { get; set; }
        public Nullable<int> HiringManagerId { get; set; }
        public Nullable<int> NumberOfPosition { get; set; }
        public string Description { get; set; }
        public Nullable<int> IsActive { get; set; }
    }
}
