using System;

namespace SFinder.Domain.Core.Interfaces.Repository.Write
{
    public interface IWriteRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}
