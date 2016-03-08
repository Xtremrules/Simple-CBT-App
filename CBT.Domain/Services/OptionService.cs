using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CBT.Domain.Services
{
    class OptionService : EntityService<Option>, IOptionService
    {
        OptionService(CBTDbContext context): base(context) { }

        public async Task<Option> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}