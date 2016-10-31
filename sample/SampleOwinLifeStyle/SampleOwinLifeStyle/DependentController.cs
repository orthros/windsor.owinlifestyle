using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SampleOwinLifeStyle
{
    [RoutePrefix("api/Dependent")]
    public class DependentController : ApiController
    {
        public IDependency DependentProperty { get; private set; }

        public DependentController(IDependency dependentProperty)
        {
            if (dependentProperty == null)
            {
                throw new ArgumentNullException(nameof(dependentProperty),
                                                $"In {this.GetType().Name} contstructor, \"{nameof(dependentProperty)}\" parameter cannot be null");
            }

            Console.WriteLine("We are constructing our dependent controller... this should happen every OWIN web request");

            DependentProperty = dependentProperty;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetDependentData()
        {
            return Ok(DependentProperty.DataPacket);
        }
    }
}