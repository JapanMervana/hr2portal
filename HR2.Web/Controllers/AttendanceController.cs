using HR2.DAL.Services;
using HR2.Utility.Unity;
using HR2.Utility.ViewModels;
using HR2.ViewModels;
using System.Web.Http;

namespace HR2.Web.Controllers
{
    public class AttendanceController : GuestBaseController
    {
        #region Readonly Properties
        private readonly AttendanceSummaryService attendanceSummaryService;
        #endregion

        public AttendanceController()
        {
           this.attendanceSummaryService = UnityUtil.Resolve<AttendanceSummaryService>();
        }

        [HttpGet]
        public APIResult AttendanceSummary(string emailID, int year,int month)
        {
           var attendanceSummary = this.attendanceSummaryService.GetAttendanceSummaryByUserName(emailID, year,month);
           return new APIResult(attendanceSummary);
        }
    }
}
