using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CBT.Domain.Services
{
    class BatchService : EntityService<Batch>, IBatchService
    {
        BatchService(CBTDbContext context) : base(context) { }

        public async Task<Batch> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Batch> GetByUniqueNumberAsync(string UniqueNumber)
        {
            throw new NotImplementedException();
        }
    }
}