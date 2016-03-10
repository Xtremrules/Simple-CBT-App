using CBT.Domain.Abstracts.Services;
using CBT.Domain.Entities;
using CBT.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace CBT.WebUI.Controllers
{
    [Authorize(Roles = "AdminRole")]
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
        public async Task<IHttpActionResult> Post([FromBody]SettingsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var settings = AutoMapper.Mapper.Map<Setting>(model);
                await _settingsService.CreateAsync(settings);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Settings/5
        public async Task<IHttpActionResult> Put(int id, [FromBody]SettingsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id == 0)
            {
                return BadRequest();
            }

            var settings = AutoMapper.Mapper.Map<Setting>(model);
            settings.ID = id;
            await _settingsService.UpdateAsync(settings);
            settings = await _settingsService.GetByIdAsync(id);
            return Ok(settings);

        }

        // DELETE: api/Settings/5
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
