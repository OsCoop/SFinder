using SFinder.Domain.Core.Entities;

namespace SFinder.Domain.Core.Interfaces.Repository.Write
{
    public interface IPrestadorServicoWriteRepository<T> : IWriteRepository<T> where T : PrestadorServico
    {
    }
}
