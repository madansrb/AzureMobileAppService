using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using AzureMobileAppServices.DataObjects;
using AzureMobileAppServices.Models;

namespace AzureMobileAppServices.Controllers
{
    public class AzureMobileAppDemoTblController : TableController<AzureMobileAppDemoTbl>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<AzureMobileAppDemoTbl>(context, Request);
        }
         

        // GET tables/AzureMobileAppDemoTbl
        public IQueryable<AzureMobileAppDemoTbl> GetAllAzureMobileAppDemoTbl()
        {
            return Query(); 
        }

        // GET tables/AzureMobileAppDemoTbl/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<AzureMobileAppDemoTbl> GetAzureMobileAppDemoTbl(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/AzureMobileAppDemoTbl/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<AzureMobileAppDemoTbl> PatchAzureMobileAppDemoTbl(string id, Delta<AzureMobileAppDemoTbl> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/AzureMobileAppDemoTbl
        public async Task<IHttpActionResult> PostAzureMobileAppDemoTbl(AzureMobileAppDemoTbl item)
        {
            AzureMobileAppDemoTbl current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/AzureMobileAppDemoTbl/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteAzureMobileAppDemoTbl(string id)
        {
             return DeleteAsync(id);
        }
    }
}
