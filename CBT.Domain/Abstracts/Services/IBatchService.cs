using CBT.Domain.Entities;
using System.Threading.Tasks;

namespace CBT.Domain.Abstracts.Services
{
    public interface IBatchService : IEntityService<Batch>
    {
        Task<Batch> GetByUniqueNumberAsync(string UniqueNumber);
        Task<Batch> ReturnBatchQuestions(string UniqueNumber);
    }
}