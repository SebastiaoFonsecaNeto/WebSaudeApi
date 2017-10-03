using System.Web.Http;
using System.Web.Http.Cors;
using WebSaude.Startup;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]

namespace WebSaude.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var enableCorsAttribute = new EnableCorsAttribute("*","*","*");
            config.EnableCors(enableCorsAttribute);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
