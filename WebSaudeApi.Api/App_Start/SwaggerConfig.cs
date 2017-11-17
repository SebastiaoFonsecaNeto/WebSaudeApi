using System;
using System.Web.Http;
using Swashbuckle.Application;
using WebActivatorEx;
using WebSaude.Api;

[assembly: PreApplicationStartMethod(typeof (SwaggerConfig), "Register")]

namespace WebSaude.Api
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof (SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "WebSaudeApi");
                    c.IncludeXmlComments(GetXmlCommentsPath());
                })
                .EnableSwaggerUi(c => { });
        }

        protected static string GetXmlCommentsPath()
        {
            return string.Format(@"{0}\bin\Swagger.XML", AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}