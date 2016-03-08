using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System;

namespace CBT.Domain.Services
{
    class SQuestionService : EntityService<SQuestion>, ISQuestionService
    {
        SQuestionService(CBTDbContext context) : base(context) { }

        public SQuestion GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}