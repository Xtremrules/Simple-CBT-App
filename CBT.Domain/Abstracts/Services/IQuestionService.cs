using CBT.Domain.Entities;

namespace CBT.Domain.Abstracts.Services
{
    public interface IQuestionService : IEntityService<Question>
    {
        Question GetById(int Id);
    }
}