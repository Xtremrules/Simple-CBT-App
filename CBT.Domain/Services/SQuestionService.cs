using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CBT.Domain.Services
{
    class SQuestionService : EntityService<SQuestion>, ISQuestionService
    {
        SQuestionService(CBTDbContext context) : base(context) { }

        public async Task<SQuestion> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}