using CBT.Domain.Entities;
using System.Threading.Tasks;

namespace CBT.Domain.Abstracts.Services
{
    public interface ISettingService : IEntityService<Setting>
    {
        Task<Setting> GetByIdAsync(int Id);
    }
}