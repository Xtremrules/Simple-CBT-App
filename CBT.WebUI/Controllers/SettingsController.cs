using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CBT.Domain.Abstracts.Services;
using CBT.Domain.Entities;
using System.Threading.Tasks;

namespace CBT.WebUI.Controllers
{
    [RoutePrefix("api/settings")]
    public class SettingsController : ApiController
    {
        ISettingService _settingsService;
        public SettingsController(ISettingService _settingsService)
        {
            this._settingsService = _settingsService;
        }
        // GET: api/Settings
        public IEnumerable<Setting> Get()
        {
            return _settingsService.GetAll();
        }

        [Route("details/{id:int}")]
        public async Task<Setting> Get(int id)
        {
            return await _settingsService.GetByIdAsync(id);
        }

        // POST: api/Settings
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Settings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Settings/5
        public void Delete(int id)
        {
        }
    }
}
