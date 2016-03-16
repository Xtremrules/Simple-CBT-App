using AutoMapper;
using CBT.Domain.Abstracts.Services;
using CBT.Domain.Entities;
using CBT.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpPost]
        [Route("{id:int}/questions")]
        public async Task<IHttpActionResult> PostQuestion(int id, [FromBody]OtherViewModel model)
        {
            if (id != model.OtherID)
                return BadRequest("Id Error");
            if (ModelState.IsValid)
            {
                var question = Mapper.Map<Question>(model);
                question =  await _questionService.CreateAsync(question);
                return Ok(question);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        [Route("{id:int}/questions")]
        public async Task<IHttpActionResult> PutQuestion([FromBody]int id, [FromBody]int Answerid)
        {
            var question = await _questionService.GetByIdAsync(id);
            if(question != null)
            {
                question.Answer = Answerid;
                question = await _questionService.UpdateAsync(question);
                return Ok(question);
            }
            throw new NullReferenceException("Question not found");
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

        [HttpPost]
        [Route("{sqid:int}/questions/{id:int}/options")]
        public async Task<IHttpActionResult> PostOptions([FromBody]OtherViewModel model)
        {
            if (ModelState.IsValid)
            {
                var option = Mapper.Map<Option>(model);
                option = await _optionService.CreateAsync(option);
                return Ok(option);
            }
            return BadRequest(ModelState);
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
                squestion = await _squestionService.CreateAsync(squestion);
                return Ok(squestion);
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
