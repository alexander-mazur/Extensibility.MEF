using Microsoft.Owin.Hosting;

using System;

namespace Extensibility.SelfHost.WebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:9000/"))
            {
                Console.WriteLine("Press ENTER for exit...");
                Console.ReadLine();
            }
        }
    }
}
