using SFinder.Domain.Core.Interfaces.Repository.Write;
using SFinder.Domain.PhotoFind.Entities;

namespace SFinder.Domain.PhotoFind.Interfaces.Repository.Write
{
    public interface IFotografoWriteRepository : IPrestadorServicoWriteRepository<Fotografo>
    {
        bool SalvarFoto(string CaminhoArquivo);
    }
}
