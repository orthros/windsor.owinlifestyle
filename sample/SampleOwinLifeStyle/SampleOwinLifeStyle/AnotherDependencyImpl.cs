using System;

namespace SampleOwinLifeStyle
{
    public class AnotherDependencyImpl : IDependency
    {
        public string DataPacket
        {
            get
            {
                return "I am a much worse implementation";
            }
        }
    }
}
