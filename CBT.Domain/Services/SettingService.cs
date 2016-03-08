using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System.Threading.Tasks;

namespace CBT.Domain.Services
{
    class SettingService : EntityService<Setting>, ISettingService
    {
        SettingService(CBTDbContext context): base(context) { }

        public async Task<Setting> GetByIdAsync(int Id)
        {
            return await _dbset.FindAsync(Id);
        }
    }
}