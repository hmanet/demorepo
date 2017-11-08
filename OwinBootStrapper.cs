using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using Owin;
using Wells.Carina.Web.API;
using Wells.Carina.Web.API.Controllers;


namespace Wells.Carina.Web.SelfHost
{
    public class OwinBootStrapper
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var test = typeof(LightGridController).AssemblyQualifiedName;
            //var idProvider = new CustomUserIdProvider();
            appBuilder.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            //GlobalHost.DependencyResolver.Register(typeof(IUserIdProvider), () => idProvider);
            appBuilder.MapSignalR();
            appBuilder.UseWebApi(config);

            CarinaSnapShotBuilder.Initialize(100);
        }
    }
}
