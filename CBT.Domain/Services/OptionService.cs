using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;

namespace CBT.Domain.Services
{
    class OptionService : EntityService<Option>, IOptionService
    {
        OptionService(CBTDbContext context): base(context) { }
    }
}