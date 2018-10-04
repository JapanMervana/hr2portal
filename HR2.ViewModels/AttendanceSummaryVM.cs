using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR2.ViewModels
{
    public class AttendanceSummaryVM
    {
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public double TotalWorkDays { get; set; }
        public double TotalAbsences { get; set; }
        public TimeSpan TotalActualWorkHours { get; set; }
        public TimeSpan TotalEditedWorkHours { get; set; }
        public TimeSpan TotalExtraOrDeficitWorkHours { get; set; }
        public string TotalActualWorkHoursString
        {
            get
            {
                return this.GetHoursAndMinutes(this.TotalActualWorkHours);
            }
        }
        public string TotalEditedWorkHoursString
        {
            get
            {
                return this.GetHoursAndMinutes(this.TotalEditedWorkHours);
            }
        }
        public string TotalExtraOrDeficitWorkHoursString
        {
            get
            {
                return this.GetHoursAndMinutes(this.TotalExtraOrDeficitWorkHours);
            }
        }
        public double TotalLeaves { get; set; }
        public List<DayWiseAttendanceSummary> DayWiseAttendanceSummary { get; set; }
        private string GetHoursAndMinutes(TimeSpan time)
        {
            return time.Hours.ToString() + ":" + time.Minutes.ToString();
        }
    }

    public class DayWiseAttendanceSummary
    {
        public string Date { get; set; }
        public string Shift { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string WorkHours { get; set; }
        public string ExtraDeficitHours { get; set; }
        public string AttendanceStatus { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
