using System.Collections.Generic;
using System.Threading.Tasks;

namespace CBT.Domain.Abstracts.Services
{
    public interface IEntityService<T> : IService where T : BaseEntity
    {
        Task<T> GetByIdAsync(int Id);
        Task CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        IEnumerable<T> GetAll();
    }
}
