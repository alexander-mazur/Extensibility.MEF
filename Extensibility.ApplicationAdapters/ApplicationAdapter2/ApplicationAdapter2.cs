using Extensibility.Common;
using System;
using System.ComponentModel.Composition;

namespace ApplicationAdapter2
{
    [Export(typeof(IApplicationAdapter))]
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
