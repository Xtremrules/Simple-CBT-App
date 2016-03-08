using CBT.Domain.Entities;

namespace CBT.Domain.Abstracts.Services
{
    public interface IOptionService : IEntityService<Option>
    {
        Option GetByID(int Id);
    }
}
