using System;
using Microsoft.Owin.Hosting;

namespace SampleOwinLifeStyle
{
    class Program
    {
        private const string baseAddress = "http://localhost:8080/OwinLifeStyleSample";

        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine(string.Format("Services started on: {0}", baseAddress));
                Console.WriteLine("Press 'Enter' to Exit");
                Console.ReadLine();
            }
        }
    }
}
