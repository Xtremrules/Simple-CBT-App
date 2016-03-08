using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System;

namespace CBT.Domain.Services
{
    class SettingService : EntityService<Setting>, ISettingService
    {
        SettingService(CBTDbContext context): base(context) { }

        public Setting GetByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}