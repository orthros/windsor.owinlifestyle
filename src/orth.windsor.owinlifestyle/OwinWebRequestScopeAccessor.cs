using Castle.MicroKernel.Context;
using Castle.MicroKernel.Lifestyle.Scoped;

namespace Orth.Windsor.Owinlifestyle
{
    internal class OwinWebRequestScopeAccessor : IScopeAccessor
    {
        public void Dispose()
        {
            var scope = PerWebRequestLifestyleOwinMiddleware.YieldScope();
            if (scope != null)
            {
                scope.Dispose();
            }
        }

        public ILifetimeScope GetScope(CreationContext context)
        {
            return PerWebRequestLifestyleOwinMiddleware.GetScope();
        }
    }
}