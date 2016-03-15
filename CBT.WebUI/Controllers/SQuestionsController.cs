using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CBT.Domain.Abstracts.Services;
using CBT.WebUI.Models;
using AutoMapper;
using CBT.Domain.Entities;
using System.Web.Http;

namespace CBT.WebUI.Controllers
{
    [Authorize(Roles = "AdminRole")]
    [RoutePrefix("api/squestions")]
    public class SQuestionsController : ApiController
    {
        // GET: api/SQuestions
        private ISQuestionService _squestionService;
        private IQuestionService _questionService;
        private IOptionService _optionService;

        public SQuestionsController(ISQuestionService _squestionService,
            IQuestionService _questionService, IOptionService _optionService)
        {
            this._optionService = _optionService;
            this._questionService = _questionService;
            this._squestionService = _squestionService;
        }
        public IEnumerable<SQuestion> Get()
        {
            return _squestionService.GetAll();
        }

        [HttpGet]
        [Route("{id:int}/questions")]
        public IHttpActionResult Questions(int id)
        {
            var questions = _questionService.GetAll().Where(x => x.SQuestionID == id).ToList();
            return Ok(questions);
        }

        [HttpGet]
        [Route("{sqid:int}/questions/{id:int}/options")]
        public IHttpActionResult Options(int sqid,int id)
        {
            var options = _optionService.GetAll().Where(x => x.QuestionID == id).ToList();
            return Ok(options);
        }
        // GET: api/SQuestions/5
        public async Task<SQuestion> Get(int id)
        {
            return await _squestionService.GetByIdAsync(id);
        }

        // POST: api/SQuestions
        public async Task<IHttpActionResult> Post([FromBody]SQuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var squestion = Mapper.Map<SQuestion>(model);
                await _squestionService.CreateAsync(squestion);
                return Ok();
            }
            return BadRequest(ModelState);
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
