using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System;

namespace CBT.Domain.Services
{
    class BatchService : EntityService<Batch>, IBatchService
    {
        BatchService(CBTDbContext context) : base(context) { }
        public Batch GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Batch GetByUniqueNumber(string UniqueNumber)
        {
            throw new NotImplementedException();
        }
    }
}