using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Linq;

namespace SampleOwinLifeStyle
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Windsor and IOC
            var _container = new WindsorContainer();
            //Use the Installers in this Assembly (public classes who inherit from IWindsorInstaller
            //Also use installers defined in the App.config
            _container.Install(FromAssembly.This(),
                               Configuration.FromAppConfig());
            _container.Kernel.Resolver.AddSubResolver(new CollectionResolver(_container.Kernel, true));
            var dependencyResolver = new WindsorDependencyResolver(_container);
            config.DependencyResolver = dependencyResolver;


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().FirstOrDefault();
            if (jsonFormatter != null)
            {
                jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            }
        }
    }
}