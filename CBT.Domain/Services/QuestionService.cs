using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CBT.Domain.Services
{
    class QuestionService : EntityService<Question>, IQuestionService
    {
        QuestionService(CBTDbContext context) : base(context) { }

        public async Task<Question> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}