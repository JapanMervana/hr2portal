using HR2.EF.DAL;
using HR2.Utility.Unity;
using HR2.ViewModels;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using HR2.Helpers.Extenstions;
using static HR2.Helpers.Enums;

namespace HR2.DAL.Services
{
    public class AttendanceSummaryService : BaseService<DBFactory>
    {
        #region Readonly Properties
        private readonly BaseRepository<AttendanceLog, DBFactory> AttendanceSummaryRepo;
        #endregion

        public AttendanceSummaryService()
        {
            this.AttendanceSummaryRepo = UnityUtil.Resolve<BaseRepository<AttendanceLog, DBFactory>>();
        }

        public List<DayWiseAttendanceSummary> GetAttendanceSummaryByUserName(string email, int year, int month)
        {
            ObjectResult<GetAttendance_Result> data;
            var list = new List<DayWiseAttendanceSummary>();

            using (var context = new HR2PortalEntities())
            {
              data = context.GetAttendance(email, month, year);
                var a = data.GetEnumerator();
                while (a.MoveNext())
                {
                    var attendanceSummaryModel = new DayWiseAttendanceSummary();
                    list.Add(new DayWiseAttendanceSummary() {
                        AttendanceStatus = AttendanceStatus.Present.DescriptionAttr(),
                        Date = a.Current.date.Value.Date.ToString(),
                        Email = a.Current.Email,
                        EmployeeName = a.Current.EmployeeName,
                        ExtraDeficitHours = a.Current.extratime,
                        InTime = a.Current.in_time,
                        Month = a.Current.month.Value,
                        OutTime = a.Current.out_time,
                        Shift = HR2.Helpers.Enums.Shift.Flexible.DescriptionAttr(), //TODO: make this dynamic by add master table for shift in db
                        WorkHours = a.Current.workhours,
                        Year = a.Current.year.Value
                    });
                }
            }

             
            return list;
        }
    }
}
