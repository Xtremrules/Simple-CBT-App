using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;

namespace CBT.Domain.Services
{
    class SQuestionService : EntityService<SQuestion>, ISQuestionService
    {
        SQuestionService(CBTDbContext context) : base(context) { }
    }
}