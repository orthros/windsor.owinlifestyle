using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orth.Windsor.Owinlifestyle
{
    public static class BasedOnDescriptorLifestyleExtension
    {
        /// <summary>
        /// Use <see cref="OwinWebRequestScopeAccessor"/> as a Scoped Lifestyle
        /// </summary>
        /// <param name="descriptor">The Descriptor</param>
        /// <returns></returns>
        public static BasedOnDescriptor LifestylePerOwinWebRequest(this BasedOnDescriptor descriptor)
        {
            return descriptor.LifestyleScoped<OwinWebRequestScopeAccessor>();
        }
    }
}
