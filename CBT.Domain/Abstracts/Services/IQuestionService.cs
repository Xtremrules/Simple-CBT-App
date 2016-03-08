using CBT.Domain.Entities;
using System.Threading.Tasks;

namespace CBT.Domain.Abstracts.Services
{
    public interface IQuestionService : IEntityService<Question>
    {
        Task<Question> GetByIdAsync(int Id);
    }
}