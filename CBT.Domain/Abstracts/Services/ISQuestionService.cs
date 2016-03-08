using CBT.Domain.Entities;
using System.Threading.Tasks;

namespace CBT.Domain.Abstracts.Services
{
    public interface ISQuestionService : IEntityService<SQuestion>
    {
        Task<SQuestion> GetByIdAsync(int Id);
    }
}