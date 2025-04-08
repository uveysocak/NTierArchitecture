using Microsoft.EntityFrameworkCore;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.DataAccess.Repositories;
public class GenericRepository<T> : IRepository<T> where T : Entity
{
    readonly ApplicationDbCtx _ctx;
    readonly DbSet<T> _dbSet;

    public GenericRepository(ApplicationDbCtx dbCtx)
    {
        _ctx = dbCtx;
        _dbSet = _ctx.Set<T>();
    }

    public void Create(T entity)
    {
        _dbSet.Add(entity);
        _ctx.SaveChanges();
    }

    public void Delete(Guid id)
    {
        _dbSet.Remove(GetById(id));
        _ctx.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T GetById(Guid id)
    {
        var find = _dbSet.Find(id);
        return find;
    }

    public void Update(T entity)
    {
        _ctx.SaveChanges();
    }
}
