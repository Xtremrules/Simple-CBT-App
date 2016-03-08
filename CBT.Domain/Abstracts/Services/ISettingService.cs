using CBT.Domain.Entities;

namespace CBT.Domain.Abstracts.Services
{
    public interface ISettingService : IEntityService<Setting>
    {
        Setting GetByID(int Id);
    }
}