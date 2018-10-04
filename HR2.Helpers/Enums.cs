using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR2.Helpers
{
    public class Enums
    {
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
}
