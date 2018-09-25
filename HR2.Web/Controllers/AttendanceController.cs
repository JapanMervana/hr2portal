using System;
using System.Collections.Generic;
using System.Web.Mvc;
using HR2.Helpers;
using HR2.Web.Models;

namespace dotnet_tutorial.Controllers
{
    [Authorize]
    public class AttendanceController : Controller
    {
        // GET: Attendance
        public ActionResult Index()
        {
            var model = new AttendanceSummary();
            model.TotalWorkDays = 22;
            model.TotalLeaves = 3.5;
            model.TotalAbsences = 1;
            model.TotalActualWorkHours = new TimeSpan(195, 23, 10);
            model.TotalEditedWorkHours = new TimeSpan(12, 00, 00);
            model.TotalExtraOrDeficitWorkHours = new TimeSpan(1, 29, 34);
            model.DayWiseAttendanceSummary = new List<DayWiseAttendanceSummary>();
            model.DayWiseAttendanceSummary.Add(new DayWiseAttendanceSummary()
            {
                AttendanceStatus = AttendanceStatus.Present.DescriptionAttr(),
                Date = DateTime.Now.Day.ToString(),
                ExtraDeficitHours = new TimeSpan(0, 16, 10),
                InTime = DateTime.Now.ToShortTimeString(),
                OutTime = DateTime.Now.ToShortTimeString(),
                Shift = Shift.Flexible.DescriptionAttr(),
                WorkHours = new TimeSpan(9, 12, 00)
            });
            model.DayWiseAttendanceSummary.Add(new DayWiseAttendanceSummary()
            {
                AttendanceStatus = AttendanceStatus.HalfDay.DescriptionAttr(),
                Date = DateTime.Now.AddDays(1).Day.ToString(),
                ExtraDeficitHours = new TimeSpan(0, 0, 0),
                InTime = DateTime.Now.ToShortTimeString(),
                OutTime = DateTime.Now.ToShortTimeString(),
                Shift = Shift.Flexible.DescriptionAttr(),
                WorkHours = new TimeSpan(5, 12, 00)
            });
            model.DayWiseAttendanceSummary.Add(new DayWiseAttendanceSummary()
            {
                AttendanceStatus = AttendanceStatus.Absent.DescriptionAttr(),
                Date = DateTime.Now.AddDays(2).Day.ToString(),
                ExtraDeficitHours = new TimeSpan(0, 0, 0),
                InTime = "00:00",
                OutTime = "00:00",
                Shift = Shift.Flexible.DescriptionAttr(),
                WorkHours = new TimeSpan(9, 12, 00)
            });
            return View(model);
        }
    }
}