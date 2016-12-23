using Extensibility.Common;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Extensibility.SelfHost.WebAPI.Composition
{
    public interface IApplicationAdapterLoader
    {
        IEnumerable<IApplicationAdapter> ApplicationAdapters { get; set; }

        void ComposeParts(string path = "Adapters");
    }
}