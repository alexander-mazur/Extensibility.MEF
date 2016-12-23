using Extensibility.SelfHost.WebAPI.Composition;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Web.Http;

namespace Extensibility.SelfHost.WebAPI.Controllers
{
    public class AdaptersController : ApiController
    {
        private IApplicationAdapterLoader _applicationAdapterLoader;

        public AdaptersController()
        {
            _applicationAdapterLoader = ApplicationAdapterLoader.Instance;
        }

        [HttpGet]
        public IEnumerable<string> GetAdapterNames()
        {
            var result = new List<string>();

            foreach (var applicationAdapter in _applicationAdapterLoader.ApplicationAdapters)
            {
                result.Add(applicationAdapter.Name);
            }

            return result;
        }
    }
}
