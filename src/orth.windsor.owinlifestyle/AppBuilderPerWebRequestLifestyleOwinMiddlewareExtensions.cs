using Owin;

namespace Orth.Windsor.Owinlifestyle
{
    public static class AppBuilderPerWebRequestLifestyleOwinMiddlewareExtensions
    {
        /// <summary>
        /// Use <see cref="PerWebRequestLifestyleOwinMiddleware"/>.
        /// </summary>
        /// <param name="app">Owin app.</param>
        /// <returns></returns>
        public static IAppBuilder UsePerWebRequestLifestyleOwinMiddleware(this IAppBuilder app)
        {
            return app.Use(typeof(PerWebRequestLifestyleOwinMiddleware));
        }
    }
}
