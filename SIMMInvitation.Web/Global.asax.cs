using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;

namespace SIMMInvitation.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            #region 依赖注入
            var builder = new ContainerBuilder();
            //注册DomainServices
            var services = Assembly.Load("SIMMInvitation.Infrastructure");
            builder.RegisterAssemblyTypes(services);
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            #endregion
        }
    }
}
