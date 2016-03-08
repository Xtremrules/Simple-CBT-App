using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System;

namespace CBT.Domain.Services
{
    class QuestionService : EntityService<Question>, IQuestionService
    {
        QuestionService(CBTDbContext context) : base(context) { }

        public Question GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}