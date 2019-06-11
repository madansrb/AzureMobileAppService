using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;

namespace AzureMobileAppServices.Controllers
{
    [MobileAppController]
    public class testController : ApiController
    {
        // GET api/test
        public string Get()
        {
            return "Hello from custom controller!";
        }
    }
}
