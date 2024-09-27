using System.Web.Http;
using WebActivatorEx;
using XPe.PrjAplicado.Monolito;
using Swashbuckle.Application;

namespace XPe.PrjAplicado.Monolito
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        
                        c.SingleApiVersion("v1", "APIs Monolito");

                        
                    })
                .EnableSwaggerUi();
        }

        protected static string GetXmlCommentsPath()
        {
            return string.Format(@"{0}\bin\XPe.PrjAplicado.Monolito.API.xml", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
