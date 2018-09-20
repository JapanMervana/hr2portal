using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotnet_tutorial.Models
{
    public class AttendanceSummary
    {
        public int TotalWorkDays { get; set; }
        public int TotalAbsences { get; set; }
        public TimeSpan TotalActualWorkHours { get; set; }
        public TimeSpan TotalEditedWorkHours { get; set; }
        public TimeSpan TotalExtraOrDeficitWorkHours { get; set; }
        public int TotalLeaves { get; set; }
        public List<DayWiseAttendanceSummary> DayWiseAttendanceSummary { get; set; }
    }

    public class DayWiseAttendanceSummary
    {
        public string Date { get; set; }
        public string Shift { get; set; }
        public String InTime { get; set; }
        public String OutTime { get; set; }
        public TimeSpan WorkHours { get; set; }
        public TimeSpan ExtraDeficitHours { get; set; }
        public string AttendanceStatus { get; set; }
    }

    public enum AttendanceStatus
    {
        [Description("Present")]
        Present,
        [Description("Absent")]
        Absent,
        [Description("Weekly Off")]
        WeeklyOff,
        [Description("Leave")]
        Leave,
        [Description("Half Day")]
        HalfDay,
        [Description("Public Holiday")]
        PublicHoliday,
        [Description("Public Holiday Worked")]
        PublicHolidayWorked,
        [Description("Work From Home")]
        WorkFromHome
    }

    public enum Shift
    {
        [Description("Flexible")]
        Flexible,
        [Description("Fixed")]
        Fixed,
        
    }
}