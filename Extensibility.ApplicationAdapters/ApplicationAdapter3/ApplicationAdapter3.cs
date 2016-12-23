using Extensibility.Common;
using System;
using System.ComponentModel.Composition;

namespace ApplicationAdapter3
{
    [Export(typeof(IApplicationAdapter))]
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
