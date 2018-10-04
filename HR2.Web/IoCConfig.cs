using HR2.EF.DAL;
using HR2.Utility.Unity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using HR2.DAL;
using HR2.DAL.Services;

namespace HR2.Web
{
    public class IoCConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            // Create UnityContainer           
            IUnityContainer container = new UnityContainer();

            // DAL
            container
                .RegisterType<DBFactory, DBFactory>(new HttpContextLifetimeManager<DBFactory>());

            // services
            container
             .RegisterType<AttendanceSummaryService, AttendanceSummaryService>(new HttpContextLifetimeManager<AttendanceSummaryService>());

            // repositories
            container
            .RegisterType<BaseRepository<AttendanceLog, DBFactory>, BaseRepository<AttendanceLog, DBFactory>>(new HttpContextLifetimeManager<BaseRepository<AttendanceLog, DBFactory>>());
           

            // Set container for use in WebB Forms
            UnityUtil.Container = container;

            // Enable Resolving directly from Controller instead of using .Resolve()
            // How to handle this with asp.net web form : http://msdn.microsoft.com/en-us/library/ff664622(v=pandp.50).aspx
            //config.DependencyResolver = new UnityResolver(container);
        }
    }
}