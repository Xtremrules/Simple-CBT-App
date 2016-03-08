using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;

namespace CBT.Domain.Services
{
    class QuestionService : EntityService<Question>, IQuestionService
    {
        QuestionService(CBTDbContext context) : base(context) { }
    }
}