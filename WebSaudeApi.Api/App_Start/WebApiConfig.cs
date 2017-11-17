using System.Web.Http;
using System.Web.Http.Cors;
using WebActivatorEx;
using WebSaude.Startup;

[assembly: PreApplicationStartMethod(typeof (NinjectWebCommon), "Start")]
[assembly: ApplicationShutdownMethod(typeof (NinjectWebCommon), "Stop")]

namespace WebSaude.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var enableCorsAttribute = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(enableCorsAttribute);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional}
                );
        }
    }
}