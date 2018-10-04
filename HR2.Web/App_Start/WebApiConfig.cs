using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Routing;

namespace HR2.Web
{
    public static class HttpRouteCollectionExtensions
    {
        public static void MapHttpRouteWithAndWithoutAction(this HttpRouteCollection routes, string name, string routeTemplate, object defaults, params string[] namespaces)
        {
            HttpRouteValueDictionary defaultsDictionary = new HttpRouteValueDictionary(defaults);
            IDictionary<string, object> tokens = new Dictionary<string, object>();
            HttpRouteValueDictionary constraintsDictionary = new HttpRouteValueDictionary(null);
            if (namespaces != null)
                tokens.Add("Namespaces", namespaces);

            IHttpRoute route1 = routes.CreateRoute(routeTemplate, defaultsDictionary, constraintsDictionary, dataTokens: tokens, handler: null);
            routes.Add(name + "WithAction", route1);

            routeTemplate = routeTemplate.Replace("{action}", string.Empty);
            routeTemplate = routeTemplate.Replace(@"//", "/");
            IHttpRoute route2 = routes.CreateRoute(routeTemplate, defaultsDictionary, constraintsDictionary, dataTokens: tokens, handler: null);
            routes.Add(name + "WithoutAction", route2);
        }

        public static IHttpRoute MapHttpRouteWithNamespace(this HttpRouteCollection routes, string name, string routeTemplate, object defaults, params string[] namespaces)
        {
            HttpRouteValueDictionary defaultsDictionary = new HttpRouteValueDictionary(defaults);
            HttpRouteValueDictionary constraintsDictionary = new HttpRouteValueDictionary(null);
            IDictionary<string, object> tokens = new Dictionary<string, object>();
            if (namespaces != null)
                tokens.Add("Namespaces", namespaces);

            IHttpRoute route = routes.CreateRoute(routeTemplate, defaultsDictionary, constraintsDictionary, dataTokens: tokens, handler: null);
            routes.Add(name, route);

            return route;
        }
    }

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute("ApiDefault", "api/{controller}/{action}/{id}", new { id = RouteParameter.Optional });
            config.Routes.MapHttpRoute("UI", "ui/{*urlPath}", new { controller = "UI" }); // for handling HTML with controller.
            config.Routes.MapHttpRouteWithAndWithoutAction("AdminApi", "api/admin/{controller}/{action}/{id}", new { id = RouteParameter.Optional }, "ZIMS.Web.Controllers.Admin");

            config.Routes.MapHttpRouteWithAndWithoutAction("ApiDefault", "api/{controller}/{action}/{id}", new { id = RouteParameter.Optional }, "ZIMS.Web.Controllers");

            //config.Routes.MapHttpRouteWithAndWithoutAction("AdminPermissionsApi", "api/admin/permissions/{controller}/{action}/{id}", new { id = RouteParameter.Optional }, "iManager.Web.API.Controllers.Admin.Permissions");



            IoCConfig.Configure(config);
        }
    }
}
