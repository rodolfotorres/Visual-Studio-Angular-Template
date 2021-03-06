﻿using System.Net.Http.Headers;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;

namespace VStorm
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            //config.Filters.Add(new AuthorizeAttribute());
            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
