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
    
    public partial class DeviceLogs_5_2017 : HR2.EF.DAL.IEFEntity
    {
        public int DeviceLogId { get; set; }
        public string AttenndanceMarkingType { get; set; }
        public System.DateTime DownloadDate { get; set; }
        public int DeviceId { get; set; }
        public string UserId { get; set; }
        public System.DateTime LogDate { get; set; }
        public string Direction { get; set; }
        public string AttDirection { get; set; }
        public string AlternateAttDirection { get; set; }
        public string StatusCode { get; set; }
        public string WorkCode { get; set; }
        public Nullable<int> Duration { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> SMSFlag { get; set; }
        public string VerificationMode { get; set; }
        public Nullable<int> IsApproved { get; set; }
        public string LogRecordLocation { get; set; }
        public string ManagerRemarks { get; set; }
        public string AttMarkAndroidIMEINo { get; set; }
    }
}
