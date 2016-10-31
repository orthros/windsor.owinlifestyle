using Owin;
using System.Web.Http;
using Orth.Windsor.Owinlifestyle;

namespace SampleOwinLifeStyle
{
    internal class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            //Enable web request lifecycle via OWIN
            app.UsePerWebRequestLifestyleOwinMiddleware();

            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }
    }
}