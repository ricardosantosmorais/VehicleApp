﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using VehicleApp.Service.Mappers;

namespace VehicleApp
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
