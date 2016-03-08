using CBT.Domain.Entities;
using System.Threading.Tasks;

namespace CBT.Domain.Abstracts.Services
{
    public interface IOptionService : IEntityService<Option>
    {
        Task<Option> GetByIdAsync(int Id);
    }
}