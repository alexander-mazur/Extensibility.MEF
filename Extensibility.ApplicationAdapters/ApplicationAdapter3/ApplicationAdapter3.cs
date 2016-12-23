using Extensibility.Common;
using System;

namespace ApplicationAdapter3
{
    public class ApplicationAdapter3 : IApplicationAdapter
    {
        public string Name
        {
            get { return "ApplicationAdapter #3"; }
        }

        public void Initialize()
        {
            Console.WriteLine("ApplicationAdapter3.Initialize() called");
        }
    }
}
