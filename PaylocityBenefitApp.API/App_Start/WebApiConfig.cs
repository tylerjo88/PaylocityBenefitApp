﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace PaylocityBenefitApp.API.App_Start
{
    public class WebApiConfig 
    {
        public static void Register(HttpConfiguration config)
        {
            // New code
            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}