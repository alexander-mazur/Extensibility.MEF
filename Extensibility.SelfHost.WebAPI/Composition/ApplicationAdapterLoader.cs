using Extensibility.Common;

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Extensibility.SelfHost.WebAPI.Composition
{
    public class ApplicationAdapterLoader : IApplicationAdapterLoader, IDisposable
    {
        // Quickly bypass DI
        public static ApplicationAdapterLoader Instance = new ApplicationAdapterLoader();

        private CompositionContainer _compositionContainer;

        [ImportMany]
        public IEnumerable<IApplicationAdapter> ApplicationAdapters { get; set; }

        private ApplicationAdapterLoader()
        {
        }

        public void ComposeParts(string path = "Adapters")
        {
            var catalog = new AggregateCatalog(new DirectoryCatalog(path));

            _compositionContainer = new CompositionContainer(catalog);
            _compositionContainer.ComposeParts(this);
        }

        public void Dispose()
        {
            _compositionContainer.Dispose();
        }
    }
}
