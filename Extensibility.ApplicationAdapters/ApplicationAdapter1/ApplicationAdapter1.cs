using Extensibility.Common;
using System;
using System.ComponentModel.Composition;

namespace ApplicationAdapter1
{
    [Export(typeof(IApplicationAdapter))]
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
