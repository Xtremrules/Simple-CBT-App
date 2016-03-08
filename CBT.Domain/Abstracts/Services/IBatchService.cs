using CBT.Domain.Entities;

namespace CBT.Domain.Abstracts.Services
{
    public interface IBatchService : IEntityService<Batch>
    {
        Batch GetById(int Id);
        Batch GetByUniqueNumber(string UniqueNumber);
    }
}