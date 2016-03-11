using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CBT.Domain.Entities;
using CBT.Domain.Abstracts.Services;
using System.Threading.Tasks;

namespace CBT.WebUI.Controllers
{
    [Authorize(Roles = "AdminRole")]
    [RoutePrefix("api/batches")]
    public class BatchesController : ApiController
    {
        IBatchService _batchService;
        public BatchesController(IBatchService _batchService)
        {
            this._batchService = _batchService;
        }
        // GET: api/Batchs
        public IEnumerable<Batch> Get()
        {
            return  _batchService.GetAll();
        }

        // GET: api/Batchs/5
        public async Task<IHttpActionResult> Get(int id)
        {
            return Ok(await _batchService.GetBatchbyId(id));
        }

        // POST: api/Batchs
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Batchs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Batchs/5
        public void Delete(int id)
        {
        }
    }
}
