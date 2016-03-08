using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;

namespace CBT.Domain.Services
{
    class SettingService : EntityService<Setting>, ISettingService
    {
        SettingService(CBTDbContext context): base(context) { }
    }
}