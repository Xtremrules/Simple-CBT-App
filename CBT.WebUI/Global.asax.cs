using CBT.WebUI.Modules;
using System;
using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web;

namespace CBT.WebUI
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new Autofac.ContainerBuilder();
            builder.RegisterApiControllers(typeof(Global).Assembly).PropertiesAutowired();
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new EFModule());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacWebApiDependencyResolver(container));
        }
    }
}