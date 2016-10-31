using System;
using System.Threading.Tasks;

namespace SampleOwinLifeStyle
{
    public class AnotherDependencyImpl : IDependency
    {
        public string DataPacket
        {
            get
            {
                Task.Delay(500).Wait();
                return "I am a much worse implementation";
            }
        }
    }
}
