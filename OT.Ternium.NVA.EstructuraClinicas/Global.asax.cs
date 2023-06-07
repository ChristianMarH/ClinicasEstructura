using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OT.Ternium.NVA.EstructuraClinicas
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            OT.Ternium.Framework.Mvc.Application.Start();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            // notificar Application_BeginRequest
            OT.Ternium.Framework.Mvc.Application.BeginRequest();
        }

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            // notificar Application_PostAuthenticateRequest
            OT.Ternium.Framework.Mvc.Application.PostAuthenticateRequest();
                    }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            // notificar Application_EndRequest
            OT.Ternium.Framework.Mvc.Application.EndRequest();
        }

    }
}
