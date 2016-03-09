using CBT.Domain.Entities;
using CBT.Domain.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CBT.Domain.Abstracts.Services
{
    public interface IBatchService : IEntityService<Batch>
    {
        Task<Batch> GetByUniqueNumberAsync(string UniqueNumber);
        Task<BatchModel> GetBatchbyId(int Id);
        Task<Batch> ReturnBatchQuestions(string UniqueNumber);
        IEnumerable<BatchModel> GetAllBatches();
    }
}