﻿using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Services;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace XPe.PrjAplicado.Monolito
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }
    }
}
