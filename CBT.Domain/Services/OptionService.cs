using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System;

namespace CBT.Domain.Services
{
    class OptionService : EntityService<Option>, IOptionService
    {
        OptionService(CBTDbContext context): base(context) { }

        public Option GetByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}