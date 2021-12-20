using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: OwinStartup(typeof(APITemplate.StartUp))]
namespace APITemplate
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888

            var config = new HttpConfiguration();
        
            config.MapHttpAttributeRoutes();

            ///Router
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
            );

            ///Json
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //Append
            app.UseWebApi(config);


        }
    }
}
