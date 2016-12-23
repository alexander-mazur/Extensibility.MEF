using Extensibility.Common;
using System;

namespace ApplicationAdapter2
{
    public class ApplicationAdapter2 : IApplicationAdapter
    {
        public string Name
        {
            get { return "ApplicationAdapter #2"; }
        }

        public void Initialize()
        {
            Console.WriteLine("ApplicationAdapter2.Initialize() called");
        }
    }
}
