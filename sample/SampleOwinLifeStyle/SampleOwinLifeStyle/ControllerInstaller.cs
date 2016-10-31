using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Orth.Windsor.Owinlifestyle;
using System.Web.Http.Controllers;

namespace SampleOwinLifeStyle
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //This tells Windsor to take all classes in this Assembly
            //that Inherit from IHttpController
            //whose name Ends With "Controller"
            //To be included in our Container (which will be used further downstream)
            //And whose lifestyle is definde by the OwinWebRequestScopeAccessor
            container.Register(Classes.FromThisAssembly()
                                      .BasedOn<IHttpController>()
                                      .If(t => t.Name.EndsWith("Controller"))
                                      .LifestyleScoped<OwinWebRequestScopeAccessor>());
        }
    }
}