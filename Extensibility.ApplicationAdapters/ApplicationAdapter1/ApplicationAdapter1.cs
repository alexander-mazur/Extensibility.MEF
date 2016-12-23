using Extensibility.Common;
using System;

namespace ApplicationAdapter1
{
    public class ApplicationAdapter1 : IApplicationAdapter
    {
        public string Name
        {
            get { return "ApplicationAdapter #1"; }
        }

        public void Initialize()
        {
            Console.WriteLine("ApplicationAdapter1.Initialize() called");
        }
    }
}
