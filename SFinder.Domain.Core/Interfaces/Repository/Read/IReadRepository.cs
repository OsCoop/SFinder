using System;
using System.Linq;

namespace SFinder.Domain.Core.Interfaces.Repository.Read
{
    public interface IReadRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
    }
}
