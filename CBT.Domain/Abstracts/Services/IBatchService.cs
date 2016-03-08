using CBT.Domain.Entities;
using System.Threading.Tasks;

namespace CBT.Domain.Abstracts.Services
{
    public interface IBatchService : IEntityService<Batch>
    {
        Task<Batch> GetByIdAsync(int Id);
        Task<Batch> GetByUniqueNumberAsync(string UniqueNumber);
    }
}