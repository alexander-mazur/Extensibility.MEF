using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Extensibility.Common;

namespace Extensibility.SelfHost.WebAPI.Controllers
{
    public class AdaptersController : ApiController
    {
        public IEnumerable<IApplicationAdapter> Get()
        {
            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotImplemented));
        }
    }
}
