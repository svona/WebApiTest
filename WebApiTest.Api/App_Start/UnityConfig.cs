using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using WebApiTest.Service;
using System;

namespace WebApiTest.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IWebApiService, WebApiService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        internal static IUnityContainer GetConfiguredContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IWebApiService, WebApiService>();
            return container;
        }
    }
}