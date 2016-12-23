using Extensibility.SelfHost.WebAPI.Composition;
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
                using (var applicationAdapterLoader = ApplicationAdapterLoader.Instance)
                {
                    applicationAdapterLoader.ComposeParts();

                    foreach (var applicationAdapter in applicationAdapterLoader.ApplicationAdapters)
                    {
                        applicationAdapter.Initialize();
                    }

                    Console.WriteLine("Press ENTER for exit...");
                    Console.ReadLine();
                }
            }
        }
    }
}
