using System;

namespace SampleOwinLifeStyle
{
    public class ADependencyImpl : IDependency
    {
        public string DataPacket
        {
            get
            {
                return "I am an implementation";
            }
        }
    }
}
