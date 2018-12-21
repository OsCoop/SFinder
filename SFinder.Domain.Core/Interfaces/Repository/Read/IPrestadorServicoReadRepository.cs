using SFinder.Domain.Core.Entities;

namespace SFinder.Domain.Core.Interfaces.Repository.Read
{
    public interface IPrestadorServicoReadRepository<T> : IReadRepository<T> where T : PrestadorServico
    {
    }
}
