using Autofac;
using Autofac.Integration.WebApi;
using CBT.Domain.Entities;
using CBT.WebUI.Models;
using CBT.WebUI.Modules;
using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

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
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            //DependencyResolver.SetResolver(new AutofacWebApiDependencyResolver(container));

            AutoMapper.Mapper.Initialize(x =>
            {
                x.CreateMap<SettingsViewModel, Setting>();
                x.CreateMap<SQuestionViewModel, SQuestion>();
                x.CreateMap<OtherViewModel, Question>()
                .ForMember(c => c.Content, r => r.MapFrom(y => y.Content))
                .ForMember(c => c.SQuestionID, r => r.MapFrom(y => y.OtherID));

                x.CreateMap<OtherViewModel, Option>()
                .ForMember(c => c.Content, r => r.MapFrom(y => y.Content))
                .ForMember(c => c.QuestionID, r => r.MapFrom(y => y.OtherID));
            });
        }
    }
}