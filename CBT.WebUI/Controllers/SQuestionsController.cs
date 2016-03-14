using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CBT.WebUI.Controllers
{
    [Authorize(Roles = "AdminRole")]
    [RoutePrefix("api/squestions")]
    public class SQuestionsController : ApiController
    {
        // GET: api/SQuestions
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SQuestions/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SQuestions
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SQuestions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SQuestions/5
        public void Delete(int id)
        {
        }
    }
}
