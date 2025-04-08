using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.DataAccess.Abstractions;
public interface IRepository<T> where T : Entity
{
    void Create(T entity);
    void Update(T entity);
    void Delete(Guid id);
    IEnumerable<T> GetAll();
    T GetById(Guid id);
}
