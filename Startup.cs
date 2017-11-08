using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Wells.Carina.Web.API;
using Wells.Carina.Web.API.Controllers;
using Wells.Carina.Web.Hosting;

[assembly: OwinStartup(typeof(Wells.Carina.Web.Hosting.Startup))]

namespace Wells.Carina.Web.Hosting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = GlobalConfiguration.Configuration;

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            var test = typeof (LightGridController).AssemblyQualifiedName;
            //WebApiConfig.Register(config);
            GlobalConfiguration.Configure(WebApiConfig.Register);

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            //GlobalHost.DependencyResolver.Register(typeof(IUserIdProvider), () => idProvider);
            app.MapSignalR();
            app.UseWebApi(config);

            CarinaSnapShotBuilder.Initialize(100);
            //ConfigureAuth(app);
        }
    }
}
