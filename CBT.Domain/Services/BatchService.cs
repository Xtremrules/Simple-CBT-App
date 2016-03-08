using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System.Data.Entity;
using System.Threading.Tasks;

namespace CBT.Domain.Services
{
    class BatchService : EntityService<Batch>, IBatchService
    {
        BatchService(CBTDbContext context) : base(context) { }

        public async Task<Batch> GetByUniqueNumberAsync(string UniqueNumber)
        {
            return await _dbset.SingleOrDefaultAsync(x => x.UniqueNumber == UniqueNumber);
        }
    }
}